using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using SharpDestiny.Enums;

namespace SharpDestiny {

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
