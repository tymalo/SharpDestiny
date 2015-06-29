using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Enums {

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