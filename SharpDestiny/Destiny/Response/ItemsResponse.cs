using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;

namespace SharpDestiny.Destiny.Response
{
    public class ItemsResponse : Responses.Response
    {
        
        public ICollection<Item> Items;

        public ItemsResponse(JObject j) : base(j)
        {
           Items = new List<Item>();

            if (j["Response"] != null)
            {
                j["Response"]["definitions"]["items"].ForEach(uObj =>
                {
                   
                });
            }
        }
    }
}
