﻿using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum NotificationMethod {

		[EnumMember]
		Email = 1,

		[EnumMember]
		MobilePush = 2,

		[EnumMember]
		WebOnly = 3

	}

}