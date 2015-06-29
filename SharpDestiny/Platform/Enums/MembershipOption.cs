using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum MembershipOption {

		[EnumMember]
		Reviewed = 0,

		[EnumMember]
		Open = 1,

		[EnumMember]
		Closed = 2

	}

}