using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Stats
    {
        [DataMember(Name = "STAT_DEFENSE")]
        public STATDEFENSE STATDEFENSE { get; set; }

        [DataMember(Name = "STAT_INTELLECT")]
        public STATINTELLECT STATINTELLECT { get; set; }

        [DataMember(Name = "STAT_DISCIPLINE")]
        public STATDISCIPLINE STATDISCIPLINE { get; set; }

        [DataMember(Name = "STAT_STRENGTH")]
        public STATSTRENGTH STATSTRENGTH { get; set; }

        [DataMember(Name = "STAT_LIGHT")]
        public STATLIGHT STATLIGHT { get; set; }

        [DataMember(Name = "STAT_ARMOR")]
        public STATARMOR STATARMOR { get; set; }

        [DataMember(Name = "STAT_AGILITY")]
        public STATAGILITY STATAGILITY { get; set; }

        [DataMember(Name = "STAT_RECOVERY")]
        public STATRECOVERY STATRECOVERY { get; set; }

        [DataMember(Name = "STAT_OPTICS")]
        public STATOPTICS STATOPTICS { get; set; }

        public Stats() {}

        public Stats(JObject j)
        {
            STATDEFENSE = new STATDEFENSE(j);
            STATINTELLECT = new STATINTELLECT(j);
            STATDISCIPLINE = new STATDISCIPLINE(j);
            STATSTRENGTH = new STATSTRENGTH(j);
            STATLIGHT = new STATLIGHT(j);
            STATARMOR = new STATARMOR(j);
            STATAGILITY = new STATAGILITY(j);
            STATRECOVERY = new STATRECOVERY(j);
            STATOPTICS = new STATOPTICS(j);
        }
    }
}
