using System.Runtime.Serialization;
using System;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	[Flags]
	public enum StatFeedbackState {

		[EnumMember]
		Good = 0,

		[EnumMember]
		TooHigh = 1,

		[EnumMember]
		TooLow = 2,

		[EnumMember]
		WrongName = 4

	}

}