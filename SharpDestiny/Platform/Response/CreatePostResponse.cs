using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Platform.Response {
	[DataContract]
	public class CreatePostResponse : Common.Response {
		
		[DataMember]
		public Post Post;

		public CreatePostResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				Post = new Post(j["Response"].Value<JObject>());
			}
		}
	}
}
