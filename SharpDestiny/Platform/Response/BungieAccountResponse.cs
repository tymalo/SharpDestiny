using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Platform.Response
{
    [DataContract]
    public class BungieAccountResponse : Common.Response
    {
        [DataMember]
        public BungieAccount BungieAccount;

        public BungieAccountResponse(JObject j) : base(j)
        {
            if (j["Response"] != null)
            {
                BungieAccount = new BungieAccount(j["Response"].Value<JObject>());
            }
        }
    }
}
