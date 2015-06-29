using System;
using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum InvitationResponseState {

		[EnumMember]
		Unreviewed = 0,

		[EnumMember]
		Approved = 1,

		[EnumMember]
		Rejected = 2

	}

}