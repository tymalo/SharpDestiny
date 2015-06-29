using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Platform.Response {

	[DataContract]
	public class GetCountsResponse : Common.Response {

		[DataMember]
		public int OnlineFriendCount;

		[DataMember]
		public int MessageCount;

		[DataMember]
		public int NotificationCount;

		public GetCountsResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				OnlineFriendCount = j["Response"]["onlineFriendCount"].Value<int>();
				MessageCount = j["Response"]["messageCount"].Value<int>();
				NotificationCount = j["Response"]["notificationCount"].Value<int>();
			}
		}
	}
}
