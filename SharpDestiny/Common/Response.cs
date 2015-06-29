using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Enums;

namespace SharpDestiny.Common {
	
	[DataContract]
	public abstract class Response {

		[DataMember]
		public PlatformErrorCodes ErrorCode;

		[DataMember]
		public string ErrorStatus;

		//If this is set as a data member, the web service fails
		public object MessageData;

		[DataMember]
		public string Message;

		[DataMember]
		public int ThrottleSeconds;


		public Response() {

		}

		public Response(PlatformErrorCodes code, string status, object msgData, string msg, int throttleSeconds) {
			ErrorCode = code;
			ErrorStatus = status;
			MessageData = msgData;
			Message = msg;
			ThrottleSeconds = throttleSeconds;
		}

		public Response(JObject j) : this(
			(PlatformErrorCodes)j["ErrorCode"].Value<int>(),
			j["ErrorStatus"].Value<string>(),
			j["MessageData"].Value<object>(),
			j["Message"].Value<string>(),
			j["ThrottleSeconds"].Value<int>())
		{
		}

	}
}
