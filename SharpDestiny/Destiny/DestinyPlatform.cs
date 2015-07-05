using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SharpDestiny.Common;
using SharpDestiny.Destiny.Enums;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform;
using SharpDestiny.Platform.Model;
using SharpDestiny.Platform.Response;

namespace SharpDestiny.Destiny
{
    public class DestinyPlatform : IDestinyPlatform
    {
        /// <summary>
        /// http://www.bungie.net/platform/Destiny/2/Account/4611686018428828459/
        /// </summary>
        /// <param name="membershipType">2</param>
        /// <param name="membershipId">4611686018428828459</param>
        /// <returns></returns>
        public async Task<DestinyAccountResponse> DestinyAccount(int membershipType, string membershipId)
        {
            string path = string.Format("/Destiny/{0}/Account/{1}", membershipType, membershipId);
            JObject j = await NoAuthRequest(path);

            return new DestinyAccountResponse(j);
        }

        /// <summary>
        /// http://www.bungie.net/platform/Destiny/2/Stats/GetMembershipIdByDisplayName/GameCompanion/
        /// </summary>
        /// <param name="membershipType">2</param>
        /// <param name="displayName">GameCompanion</param>
        /// <returns></returns>
        public async Task<MembershipResponse> GetMembershipIdByDisplayName(int membershipType, string displayName)
        {
            string path = string.Format("/Destiny/{0}/Stats/GetMembershipIdByDisplayName/{1}", membershipType, displayName);
            JObject j = await NoAuthRequest(path);

            return new MembershipResponse(j);
        }

        /// <summary>
        /// http://www.bungie.net/platform/User/GetBungieAccount/8974337/254/
        /// </summary>
        /// <param name="memberId">8974337</param>
        /// <returns></returns>
        public async Task<BungieAccountResponse> BungieAccount(int memberId)
        {
            string path = string.Format("/User/GetBungieAccount/{0}/{1}",memberId,254);
            JObject j = await NoAuthRequest(path);

            return new BungieAccountResponse(j);
        }

        /// <summary>
        /// http://www.bungie.net/Platform/Destiny/2/Account/4611686018428828459/Character/2305843009216514616/Inventory/?lc=en&fmt=true&lcin=true&definitions=true
        /// need to set definitions=true to retrive actual item info
        /// </summary>
        /// <param name="accountId">4611686018428828459</param>
        /// <param name="characterId">2305843009216514616</param>
        /// <returns></returns>
        public async Task<CharacterInventoryResponse> GetCharacterInventory(string accountId, string characterId)
        {
            string path = string.Format("/Destiny/2/Account/{0}/Character/{1}/Inventory/?lc=en&fmt=true&lcin=true&definitions=true", accountId, characterId);
            JObject j = await NoAuthRequest(path);

            return new CharacterInventoryResponse(j);
        }

        public IList<Item> FindCharacterItemsByBucketName(CharacterInventoryResponse characterInventory,DestinyBucketNames bucketName)
        {
            var result = new List<Item>();
            Bucket bucketHash = characterInventory.Buckets.FirstOrDefault(x => x.BucketName == bucketName.ToDescription());

            if (bucketHash != null) {
                result.AddRange(characterInventory.Items.Where(x => x.BucketTypeHash == bucketHash.BucketHash).ToList());

                foreach (Item item in result)
                {
                    item.Perks = new List<Perk>();
                    List<Item> equippables = characterInventory.Equippable.Where(x => x.ItemHash == item.ItemHash).ToList();

                    foreach (var equippable in equippables)
                    {
                        foreach (var perk in equippable.Perks)
                        {
                            var definition = characterInventory.Perks.FirstOrDefault(x => x.PerkHash == perk.PerkHash);
                            if (definition != null)
                            {
                                perk.DisplayName = definition.DisplayName;
                                perk.DisplayDescription = definition.DisplayDescription;
                                perk.DisplayIcon = definition.DisplayIcon;
                                perk.IsDisplayable = definition.IsDisplayable;
                            }
                            item.Perks.Add(perk);
                        }    
                    }
                }
            }

            return result;
        }

        public DestinyAccountCharacters FindDestinyAccountCharacters(int membershipType, string gamertag)
        {
            var x = new DestinyAccountCharacters();

            ////try find by http://www.bungie.net/platform/Destiny/2/Stats/GetMembershipIdByDisplayName/GameCompanion/
            //Task<MembershipResponse> membershipResponse = GetMembershipIdByDisplayName(membershipType, gamertag);

            //if (membershipResponse.Result.Membership != null)
            //{
            //    x.MembershipId = membershipResponse.Result.Membership.MembershipId;
            //    //http://www.bungie.net/platform/Destiny/2/Account/4611686018428828459/
            //    Task<DestinyAccountResponse> destinyAccountResponse = DestinyAccount(membershipType, membershipResponse.Result.Membership.MembershipId);

            //    if (destinyAccountResponse.Result.DestinyAccount.Characters != null)
            //    {
            //        x.Characters.AddRange(destinyAccountResponse.Result.DestinyAccount.Characters);

            //        return x;
            //    }
            //}


            //no luck with above method, let's try soemthing else
            var bungiePlatfom = new BungiePlatform();
            Task<UsersPagedResponse> query = bungiePlatfom.SearchUsersPaged(null, gamertag, 1);
            UsersPagedResponse usersPagedResponse = query.Result;

            if (usersPagedResponse.UsersPaged.Users.Any())
            {
                IEnumerable<int> memberIds = usersPagedResponse.UsersPaged.Users.Select(u => u.MemberId);

                foreach (var memberId in memberIds)
                {
                    Task<BungieAccountResponse> _bungieAccountResponse = BungieAccount(memberId);

                    if (_bungieAccountResponse.Result.BungieAccount != null)
                    {
                        if (_bungieAccountResponse.Result.BungieAccount.DestinyAccounts.Any())
                        {
                            var destinyAccount = _bungieAccountResponse.Result.BungieAccount.DestinyAccounts.First();

                            if (destinyAccount.UserInfo != null)
                            {
                                x.MembershipId = destinyAccount.UserInfo.MembershipId;
                            }
                            if (destinyAccount.Characters.Any())
                            {
                                x.Characters.AddRange(destinyAccount.Characters);
                            }

                            return x;
                        }
                    }
                }
            }

            return x;
        }

        /// <summary>
        /// Make an unauthenticated request
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private async Task<JObject> NoAuthRequest(string path)
        {
            HttpResponseMessage msg;
            string str;

            using (HttpClientHandler handler = new HttpClientHandler())
                using (HttpClient client = new HttpClient(handler))
                {
                    handler.UseCookies = true;

                    msg = await client.GetAsync(BungieNet.PlatformPath + path);
                    str = await msg.Content.ReadAsStringAsync();

                    return JObject.Parse(str);
                }
        }
    }
}