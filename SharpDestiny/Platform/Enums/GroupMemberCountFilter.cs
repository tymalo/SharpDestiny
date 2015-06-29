using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum GroupMemberCountFilter {

		[EnumMember]
		All = 0,

		[EnumMember]
		OneToTen = 1,

		[EnumMember]
		ElevenToOneHundred = 2,

		[EnumMember]
		GreaterThanOneHundred = 3

	}

}