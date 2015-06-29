using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum RequestedPunishment {

		[EnumMember]
		Ban = 0,

		[EnumMember]
		Warn = 1,

		[EnumMember]
		BlastBan = 2

	}

}