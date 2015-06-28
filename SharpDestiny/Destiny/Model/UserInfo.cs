using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class UserInfo
    {
        [DataMember(Name = "iconPath")]
        public string IconPath { get; set; }

          [DataMember(Name = "membershipType")]
        public int MembershipType { get; set; }

          [DataMember(Name = "membershipId")]
        public string MembershipId { get; set; }

          [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }

          public UserInfo(JObject j)
          {
              IconPath = j["iconPath"].Value<string>();
              MembershipType = j["membershipType"].Value<int>();
              MembershipId = j["membershipId"].Value<string>();
              DisplayName = j["displayName"].Value<string>();
		}
    }
}
