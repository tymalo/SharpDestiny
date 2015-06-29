using System;
using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum EntityType {

		[EnumMember]
		None = 0,

		[EnumMember]
		User = 1,

		[EnumMember]
		Group = 2,

		[EnumMember]
		Post = 3,

		[EnumMember]
		Invitation = 4,

		[EnumMember]
		Report = 5,

		[EnumMember]
		Activity = 6,

		[EnumMember]
		Conversation = 7,

		[EnumMember]
		Tag = 8

	}

}