using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Responses {
	[DataContract]
	public class CurrentUserResponse : Response {

		[DataMember]
		public CurrentUser User;


		public CurrentUserResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				User = new CurrentUser(j["Response"].Value<JObject>());
			}

		}

	}
}
