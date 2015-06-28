using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform.Model;
using SharpDestiny.Platform.Response;
using SharpDestiny.Responses.Destiny;

namespace SharpDestiny.Destiny
{
    public class PlatformDestiny : IPlatformDestiny
    {
        public async Task<AccountResponse> Account(int membershipType, string membershipId)
        {
            string path = string.Format("/Destiny/{0}/DestinyAccount/{1}", membershipType, membershipId);
            JObject j = await NoAuthRequest(path);

            return new AccountResponse(j);
        }

        public async Task<MembershipResponse> GetMembershipIdByDisplayName(int membershipType, string displayName)
        {
            string path = string.Format("/Destiny/{0}/Stats/GetMembershipIdByDisplayName/{1}", membershipType, displayName);
            JObject j = await NoAuthRequest(path);

            return new MembershipResponse(j);
        }

        /// <summary>
        /// http://www.bungie.net/platform/User/SearchUsersPaged/superg00dadvice/1/
        /// </summary>
        /// <param name="membershipType"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<PlayerResponse> SearchPlayer(int membershipType, string userName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// http://www.bungie.net/platform/User/GetBungieAccount/8974337/254/
        /// </summary>
        /// <param name="membershipId"></param>
        /// <returns></returns>
        public async Task<BungieAccountResponse> BungieAccount(int membershipId)
        {
            string path = string.Format("/User/GetBungieAccount/{0}/{1}",membershipId,254);
            JObject j = await NoAuthRequest(path);

            return new BungieAccountResponse(j);
        }

        public Task<MembershipResponse> GetCharacterInventory(string accountId, string characterId)
        {
            throw new NotImplementedException();
        }

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