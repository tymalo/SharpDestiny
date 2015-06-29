using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Platform.Model {

	[DataContract]
	public class Context {

		[DataMember]
		public bool Following;

		[DataMember]
		public IgnoreStatus IgnoreStatus;

		public Context(JObject j) {
			Following = j["isFollowing"].Value<bool>();
			IgnoreStatus = new IgnoreStatus(j["ignoreStatus"].Value<JObject>());
		}
	}
}
