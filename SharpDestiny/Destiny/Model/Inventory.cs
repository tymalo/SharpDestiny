using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Inventory
    {
        [DataMember(Name = "buckets")]
        public ICollection<Bucket> Buckets { get; set; }

        [DataMember(Name = "currencies")]
        public ICollection<Currency> Currencies { get; set; }

        public Inventory(){}

        public Inventory(JObject j)
        {
            Buckets = new List<Bucket>();
            Currencies = new List<Currency>();


            if (j["buckets"] != null)
            {
                j["buckets"].Cast<JObject>().ForEach(x => Buckets.Add(new Bucket(x)));
            }

            if (j["currencies"] != null)
            {
                j["currencies"].Cast<JObject>().ForEach(x => Currencies.Add(new Currency(x)));
            }
		}
    }
}
