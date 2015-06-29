using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Inventory
    {
        [DataMember(Name = "buckets")]
        public Buckets Buckets { get; set; }

        [DataMember(Name = "currencies")]
        public IList<Currency> Currencies { get; set; }

        public Inventory(){}

        public Inventory(JObject j)
        {
            Buckets = new Buckets(j);

            Currencies = new List<Currency>();

            foreach (JObject c in j["inventory"]["currencies"])
            {
                Currencies.Add(new Currency(c));
            }
		}
    }
}
