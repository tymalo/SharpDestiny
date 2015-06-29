using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class STATLIGHT
    {
        [DataMember(Name = "statHash")]
        public object StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATLIGHT() { }

        public STATLIGHT(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_LIGHT"]["statHash"].Value<object>();
            Value = j["characterBase"]["stats"]["STAT_LIGHT"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_LIGHT"]["maximumValue"].Value<int>();
        }
    }
}