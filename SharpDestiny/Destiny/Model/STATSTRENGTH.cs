using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class STATSTRENGTH
    {
        [DataMember(Name = "statHash")]
        public object StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATSTRENGTH() { }

        public STATSTRENGTH(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_STRENGTH"]["statHash"].Value<object>();
            Value = j["characterBase"]["stats"]["STAT_STRENGTH"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_STRENGTH"]["maximumValue"].Value<int>();
        }
    }
}