using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SharpDestiny.Destiny.Response;
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
        public async Task<AccountResponse> Account(int membershipType, string membershipId)
        {
            string path = string.Format("/Destiny/{0}/DestinyAccount/{1}", membershipType, membershipId);
            JObject j = await NoAuthRequest(path);

            return new AccountResponse(j);
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
        /// http://www.bungie.net/BungiePlatform/Destiny/2/Account/4611686018428828459/Character/2305843009216514616/Inventory/?lc=en&fmt=true&lcin=true&definitions=true
        /// need to set definitions=true to retrive actual item info
        /// </summary>
        /// <param name="accountId">4611686018428828459</param>
        /// <param name="characterId">2305843009216514616</param>
        /// <returns></returns>
        public async Task<ItemsResponse> GetCharacterInventory(string accountId, string characterId)
        {
            string path = string.Format("/Destiny/2/Account/{0}/Character/{1}/Inventory/?lc=en&fmt=true&lcin=true&definitions=true", accountId, characterId);
            JObject j = await NoAuthRequest(path);

            return new ItemsResponse(j);
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