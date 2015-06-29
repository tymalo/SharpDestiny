using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;
using SharpDestiny.Destiny.Model;

namespace SharpDestiny.Destiny.Response
{
    [DataContract]
    public class ItemsResponse : Common.Response
    {
        [DataMember]
        public ICollection<Item> Items;

        public ItemsResponse(JObject j) : base(j)
        {
           Items = new List<Item>();

            if (j["Response"] != null)
            {
                j["Response"]["definitions"]["items"].ForEach(x =>
                {
                    var jObj = x.First.Value<JObject>();
                    Items.Add(new Item(jObj));
                });
            }
        }
    }
}
