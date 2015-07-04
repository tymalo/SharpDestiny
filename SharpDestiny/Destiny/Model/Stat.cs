using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Stat
    {
        [DataMember(Name = "statHash")]
        public string StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        [DataMember(Name = "minimumValue")]
        public int MinimumValue { get; set; }

        [DataMember(Name = "maximum")]
        public int Maximum { get; set; }

        [DataMember(Name = "minimum")]
        public int Minimum { get; set; }

        [DataMember(Name = "statName")]
        public string StatName { get; set; }

        [DataMember(Name = "statDescription")]
        public string StatDescription { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "statIdentifier")]
        public string StatIdentifier { get; set; }

        [DataMember(Name = "interpolate")]
        public string Interpolate { get; set; }

        public Stat(JObject j)
        {
            StatHash = j["statHash"] != null ? j["statHash"].Value<string>() : null;
            if (j["value"] != null)
            {
                Value = j["value"].Value<int>();
            }
            
            if (j["maximumValue"] != null)
            {
                MaximumValue = j["maximumValue"].Value<int>();
            }
        
            if (j["maximumValue"] != null)
            {
                MaximumValue = j["maximumValue"].Value<int>();
            }
            if (j["minimumValue"] != null)
            {
                Minimum = j["minimumValue"].Value<int>();
            }
            if (j["maximum"] != null)
            {
                Maximum = j["maximum"].Value<int>();
            }
            if (j["minimum"] != null)
            {
                Minimum = j["minimum"].Value<int>();
            }

            StatName = j["statName"] != null ? j["statName"].Value<string>() : null;
            StatDescription = j["statDescription"] != null ? j["statDescription"].Value<string>() : null;
            Icon = j["icon"] != null ? j["icon"].Value<string>() : null;
            StatIdentifier = j["statIdentifier"] != null ? j["statIdentifier"].Value<string>() : null;
            Interpolate = j["interpolate"] != null ? j["interpolate"].Value<string>() : null;
        }
    }
}