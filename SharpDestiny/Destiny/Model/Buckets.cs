using System.Collections.Generic;

using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Buckets
    {
        [DataMember(Name = "Invisible")]
        public IList<object> Invisible { get; set; }

        [DataMember(Name = "Item")]
        public IList<Item> Items { get; set; }

        [DataMember(Name = "Currency")]
        public IList<object> Currency { get; set; }

        public Buckets(){}

        public Buckets(JObject j)
        {
            Invisible = new List<object>();
            Items = new List<Item>();
            Currency = new List<object>();
		}
    }
}
