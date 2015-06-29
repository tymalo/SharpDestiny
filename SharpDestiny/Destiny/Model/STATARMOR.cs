using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class STATARMOR
    {

        [DataMember(Name = "statHash")]
        public int StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATARMOR() { }

        public STATARMOR(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_ARMOR"]["statHash"].Value<int>();
            Value = j["characterBase"]["stats"]["STAT_ARMOR"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_ARMOR"]["maximumValue"].Value<int>();
        }
    }
}