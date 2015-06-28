using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class DestinyAccount
    {
        [DataMember(Name = "membershipId")]
        public string MembershipId { get; set; }

        [DataMember(Name = "membershipType")]
        public int MembershipType { get; set; }

        [DataMember(Name = "clanName")]
        public string ClanName { get; set; }

        [DataMember(Name = "clanTag")]
        public string ClanTag { get; set; }

        [DataMember(Name = "grimoireScore")]
        public int GrimoireScore { get; set; }

        [DataMember(Name = "inventory")]
        public Inventory Inventory { get; set; }

        [DataMember(Name = "userInfo")]
        public UserInfo UserInfo { get; set; }

        [DataMember(Name = "characters")]
        public IList<Character> Characters { get; set; }

        public DestinyAccount() {}

		public DestinyAccount(JObject j) {
            if (j["membershipId"] != null) {
                MembershipId = j["membershipId"].Value<string>();
		    }
            if (j["membershipType"] != null) {
                MembershipType = j["membershipType"].Value<int>();
            }
            ClanName = j["clanName"].Value<string>();
            ClanTag = j["clanTag"].Value<string>();
            GrimoireScore = j["grimoireScore"].Value<int>();
            Characters = new List<Character>();

		    if (j["userInfo"] != null) {
                UserInfo = new UserInfo(j["userInfo"].Value<JObject>());
		    }
		
		    if (j["inventory"] != null) {  
                Inventory = new Inventory(j["inventory"].Value<JObject>());
		    }

		    if (j["characters"] != null) {
		        j["characters"].Cast<JObject>().ForEach(x => Characters.Add(new Character(x)));
		    }
		}
    }
}
