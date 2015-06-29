using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Platform.Response {
	[DataContract]
	public class CurrentUserResponse : Common.Response {

		[DataMember]
		public CurrentUser User;


		public CurrentUserResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				User = new CurrentUser(j["Response"].Value<JObject>());
			}
		}
	}
}
