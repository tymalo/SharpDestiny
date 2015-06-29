using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Enums;

namespace SharpDestiny.Platform.Model {

	[DataContract]
	public class IgnoreStatus {

		[DataMember]
		public bool Ignored;

		[DataMember]
		public IgnoreFlags Flags;

		public IgnoreStatus(JObject j) {
			Ignored = j["isIgnored"].Value<bool>();
			Flags = (IgnoreFlags)j["ignoreFlags"].Value<int>();
		}

	}
}
