using System.Runtime.Serialization;
using System;

namespace SharpDestiny.Enums {

	[DataContract]
	[Flags]
	public enum SuccessMessages {

		[EnumMember]
		Following = 1,

		[EnumMember]
		Unfollowing = 2,

		[EnumMember]
		ManagingGroupMembers = 8,

		[EnumMember]
		UpdatingSettings = 16,

		[EnumMember]
		ManagingGroups = 32

	}

}