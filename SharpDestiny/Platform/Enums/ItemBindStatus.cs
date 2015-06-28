using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum ItemBindStatus {

		[EnumMember]
		NotBound = 0,

		[EnumMember]
		BoundToCharacter = 1,

		[EnumMember]
		BoundToAccount = 2,

		[EnumMember]
		BoundToBuild = 3

	}

}