using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Platform.Response {
	[DataContract]
	public class SaveMessageResponse : Common.Response {

		[DataMember]
		public int Id;

		public SaveMessageResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				Id = j["Response"].Value<int>();
			}
		}
	}
}
