using Newtonsoft.Json.Linq;
using SharpDestiny.Destiny.Model;

namespace SharpDestiny.Destiny.Response
{
    public class DestinyAccountResponse: Common.Response
    {
        public DestinyAccount DestinyAccount;

        public DestinyAccountResponse(JObject j): base(j)
        {
            DestinyAccount = new DestinyAccount();

            if (j["Response"] != null)
            {
                DestinyAccount = new DestinyAccount(j["Response"].Value<JObject>());
            }
        }
    }
}
