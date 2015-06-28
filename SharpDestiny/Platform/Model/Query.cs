using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny
{
    public class Query
    {
        [DataMember]
        public int ItemsPerPage;

        [DataMember]
        public int CurrentPage;

        public Query(JObject j)
        {
			ItemsPerPage = j["itemsPerPage"].Value<int>();
            CurrentPage = j["currentPage"].Value<int>();
		}
    }
}
