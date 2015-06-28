using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class STATOPTICS
    {
        [DataMember(Name = "statHash")]
        public object StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATOPTICS() { }

        public STATOPTICS(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_OPTICS"]["statHash"].Value<object>();
            Value = j["characterBase"]["stats"]["STAT_OPTICS"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_OPTICS"]["maximumValue"].Value<int>();
        }
    }
}