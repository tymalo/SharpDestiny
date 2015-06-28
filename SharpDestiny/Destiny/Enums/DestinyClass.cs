using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum DestinyClass {

		[EnumMember]
		Titan = 0,

		[EnumMember]
		Hunter = 1,

		[EnumMember]
		Warlock = 2,

		[EnumMember]
		Unknown = 3

	}

}