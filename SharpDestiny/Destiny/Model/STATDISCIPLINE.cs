using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class STATDISCIPLINE
    {
        [DataMember(Name = "statHash")]
        public int StatHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        public STATDISCIPLINE() { }

        public STATDISCIPLINE(JObject j)
        {
            StatHash = j["characterBase"]["stats"]["STAT_DISCIPLINE"]["statHash"].Value<int>();
            Value = j["characterBase"]["stats"]["STAT_DISCIPLINE"]["value"].Value<int>();
            MaximumValue = j["characterBase"]["stats"]["STAT_DISCIPLINE"]["maximumValue"].Value<int>();
        }
    }
}