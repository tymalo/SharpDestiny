using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {
	[DataContract]
	public enum MembershipOption_Old {

		[EnumMember]
		OpenWithApproval = 0,

		[EnumMember]
		Open = 1,

		[EnumMember]
		Closed = 2

	}
}
