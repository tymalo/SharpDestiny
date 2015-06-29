﻿using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {
	[DataContract]
	public enum ChatSecurity {

		[EnumMember]
		AllMembers = 0,

		[EnumMember]
		AdminsOnly = 1

	}
}
