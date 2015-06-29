using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Platform.Model {

	[DataContract]
	public class GroupResponse : Common.Response {

		[DataMember]
		public Group Group;

		public GroupResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				Group = new Group(j["Response"].Value<JObject>());
			}
		}
	}
}
