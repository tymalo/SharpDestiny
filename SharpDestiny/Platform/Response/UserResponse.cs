using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Platform.Response {
	[DataContract]
	public class UserResponse : Common.Response {

		[DataMember]
		public User User;

		public UserResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				User = new User(j["Response"].Value<JObject>());
			}
		}

	}
}
