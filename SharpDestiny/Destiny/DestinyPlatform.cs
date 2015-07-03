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
        /// http://www.bungie.net/platform/Destiny/2/DestinyAccount/4611686018428828459/
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
        /// <param name="membershipId">8974337</param>
        /// <returns></returns>
        public async Task<BungieAccountResponse> BungieAccount(int membershipId)
        {
            string path = string.Format("/User/GetBungieAccount/{0}/{1}",membershipId,254);
            JObject j = await NoAuthRequest(path);

            return new BungieAccountResponse(j);
        }

        /// <summary>
        /// http://www.bungie.net/BungiePlatform/Destiny/2/DestinyAccount/4611686018428828459/Character/2305843009216514616/Inventory/?lc=en&fmt=true&lcin=true&definitions=true
        /// need to set definitions=true to retrive actual item info
        /// </summary>
        /// <param name="accountId">4611686018428828459</param>
        /// <param name="characterId">2305843009216514616</param>
        /// <returns></returns>
        public async Task<CharacterInventoryResponse> GetCharacterInventory(string accountId, string characterId)
        {
            string path = string.Format("/Destiny/2/DestinyAccount/{0}/Character/{1}/Inventory/?lc=en&fmt=true&lcin=true&definitions=true", accountId, characterId);
            JObject j = await NoAuthRequest(path);

            return new CharacterInventoryResponse(j);
        }

        public IList<Item> FindCharacterItemsByBucketName(CharacterInventoryResponse characterInventory,DestinyBucketNames bucketName)
        {
            var result = new List<Item>();
            Bucket bucketHash = characterInventory.Buckets.FirstOrDefault(x => x.BucketName == bucketName.ToDescription());

            if (bucketHash != null) {
                result.AddRange(characterInventory.Items.Where(x => x.BucketTypeHash == bucketHash.BucketHash).ToList());
            }

            return result;
        }

        public DestinyAccountCharacters FindDestinyAccountCharacters(string gamertag)
        {
            var x = new DestinyAccountCharacters();

            //try find by http://www.bungie.net/platform/Destiny/2/Stats/GetMembershipIdByDisplayName/GameCompanion/
            Task<MembershipResponse> membershipResponse = GetMembershipIdByDisplayName(2, gamertag);

            if (membershipResponse.Result.Membership != null)
            {
                x.MembershipId = membershipResponse.Result.Membership.MembershipId;
                Task<DestinyAccountResponse> destinyAccountResponse = DestinyAccount(2, membershipResponse.Result.Membership.MembershipId);

                if (destinyAccountResponse.Result.DestinyAccount != null)
                {
                    x.Characters.AddRange(destinyAccountResponse.Result.DestinyAccount.Characters);
                }
            }


            //no luck with above method, let's try soemthing else
            var bungiePlatfom = new BungiePlatform();
            Task<UsersPagedResponse> query = bungiePlatfom.SearchUsersPaged(null, gamertag, 1);
            UsersPagedResponse usersPagedResponse = query.Result;

            if (usersPagedResponse.UsersPaged.Users.Any())
            {
                var user = usersPagedResponse.UsersPaged.Users.First();
                x.MembershipId = user.MemberId.ToString();
                Task<BungieAccountResponse> _bungieAccountResponse = BungieAccount(user.MemberId);

                if (_bungieAccountResponse.Result.BungieAccount.DestinyAccounts.Any())
                {
                    x.Characters.AddRange(_bungieAccountResponse.Result.BungieAccount.DestinyAccounts.First().Characters);
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