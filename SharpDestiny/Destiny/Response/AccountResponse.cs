using SharpDestiny.Destiny;
using Newtonsoft.Json.Linq;
using SharpDestiny.Destiny.Model;

namespace SharpDestiny.Responses.Destiny
{
    public class AccountResponse: Response
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
