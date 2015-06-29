using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class STATAGILITY
    {
        [DataMember(Name = "statHash")]
        public object StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATAGILITY() { }

        public STATAGILITY(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_AGILITY"]["statHash"].Value<object>();
            Value = j["characterBase"]["stats"]["STAT_AGILITY"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_AGILITY"]["maximumValue"].Value<int>();
        }
    }
}