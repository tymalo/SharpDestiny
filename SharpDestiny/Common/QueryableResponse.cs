using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Common {
	[DataContract]
	public class QueryableResponse : Response {

		[DataMember]
		public bool HasMore;

		[DataMember]
		public Query Query;

		[DataMember]
		public int TotalResults;


		public QueryableResponse(JObject j) : base(j){

			HasMore = j["Response"]["hasMore"].Value<bool>();
			Query = new Query(j["Response"]["query"].Value<JObject>());
			TotalResults = j["Response"]["totalResults"].Value<int>();
		}
	}
}
