using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum DestinyGender {

		[EnumMember]
		Male = 0,

		[EnumMember]
		Female = 1,

		[EnumMember]
		Unknown = 2

	}

}