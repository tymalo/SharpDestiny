using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;
using SharpDestiny.Destiny;
using SharpDestiny.Destiny.Model;

namespace SharpDestiny.Platform.Model
{
    [DataContract]
    public class BungieAccount
    {
        [DataMember]
        public int DestinyAccountResult { get;set; }

        [DataMember]
        public ICollection<DestinyAccount> DestinyAccounts;

        [DataMember]
        public User BungieNetUser { get; set; }

        public BungieAccount() {
		}
        public BungieAccount(JObject j)
        {
            DestinyAccounts = new List<DestinyAccount>();

            DestinyAccountResult = j["destinyAccountResult"].Value<int>();

            j["destinyAccounts"].Cast<JObject>().ForEach(p => DestinyAccounts.Add(new DestinyAccount(p)));

            if (j["bungieNetUser"] != null)
            {
                BungieNetUser = new User(j["bungieNetUser"].Value<JObject>());
            }
		}
    }
}
