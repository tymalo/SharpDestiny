using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class STATRECOVERY
    {
        [DataMember(Name = "statHash")]
        public int StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATRECOVERY() { }

        public STATRECOVERY(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_RECOVERY"]["statHash"].Value<int>();
            Value = j["characterBase"]["stats"]["STAT_RECOVERY"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_RECOVERY"]["maximumValue"].Value<int>();
        }
    }
}