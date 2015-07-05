using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Perk
    {
        [DataMember(Name = "iconPath")]
        public string IconPath { get; set; }

        [DataMember(Name = "perkHash")]
        public string PerkHash { get; set; }

        [DataMember(Name = "isActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }

        [DataMember(Name = "displayDescription")]
        public string DisplayDescription { get; set; }

        [DataMember(Name = "displayIcon")]
        public string DisplayIcon { get; set; }

        [DataMember(Name = "isDisplayable")]
        public bool IsDisplayable { get; set; }

        public Perk(JObject j)
        {
            PerkHash = j["perkHash"] != null ? j["perkHash"].Value<string>() : null;
            IconPath = j["iconPath"] != null ? j["iconPath"].Value<string>() : null;
            IsActive = j["isActive"] != null && j["isActive"].Value<bool>();
     
            DisplayName = j["displayName"] != null ? j["displayName"].Value<string>() : null;
            DisplayDescription = j["displayDescription"] != null ? j["displayDescription"].Value<string>() : null;
            DisplayIcon = j["displayIcon"] != null ? j["displayIcon"].Value<string>() : null;

            IsDisplayable = j["isDisplayable"] != null && j["isDisplayable"].Value<bool>();
        }
    }
}