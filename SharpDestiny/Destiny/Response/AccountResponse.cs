using Newtonsoft.Json.Linq;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Common;

namespace SharpDestiny.Destiny.Response
{
    public class AccountResponse: Common.Response
    {
        public DestinyAccount DestinyAccount;

        public AccountResponse(JObject j): base(j)
        {
            DestinyAccount = new DestinyAccount();

            if (j["Response"] != null)
            {
                DestinyAccount = new DestinyAccount(j["Response"].Value<JObject>());
            }
        }
    }
}
