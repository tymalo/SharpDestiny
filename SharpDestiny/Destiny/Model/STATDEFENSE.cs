using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class STATDEFENSE
    {
        [DataMember(Name = "statHash")]
        public object StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATDEFENSE() {}

        public STATDEFENSE(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_DEFENSE"]["statHash"].Value<object>();
            Value = j["characterBase"]["stats"]["STAT_DEFENSE"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_DEFENSE"]["maximumValue"].Value<int>();
        }
    }
}