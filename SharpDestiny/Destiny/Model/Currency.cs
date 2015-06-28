using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Currency
    {
        [DataMember(Name = "itemHash")]
        public long ItemHash { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }

        public Currency(){}

        public Currency(JObject j)
        {
            ItemHash = j["itemHash"].Value<long>();
            Value = j["value"].Value<int>();
		}
    }
}
