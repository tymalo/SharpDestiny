using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Perk
    {
        [DataMember(Name="iconPath")]
        public string IconPath { get; set; }

        [DataMember(Name="perkHash")]
        public string PerkHash { get; set; }

        [DataMember(Name="isActive")]
        public bool IsActive { get; set; }

        public Perk(JObject j)
        {
            PerkHash = j["perkHash"] != null ? j["perkHash"].Value<string>() : null;
            IconPath = j["iconPath"] != null ? j["iconPath"].Value<string>() : null;
            IsActive = j["isActive"].Value<bool>();
        }
    }
}