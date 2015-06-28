using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class STATINTELLECT
    {
        [DataMember(Name = "statHash")]
        public int StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATINTELLECT() { }

        public STATINTELLECT(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_INTELLECT"]["statHash"].Value<int>();
            Value = j["characterBase"]["stats"]["STAT_INTELLECT"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_INTELLECT"]["maximumValue"].Value<int>();
        }
    }
}