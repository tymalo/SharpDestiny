using System;
using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum BucketCategory {

		[EnumMember]
		Invisible = 0,

		[EnumMember]
		Item = 1,

		[EnumMember]
		Currency = 2,

		[EnumMember]
		Equippable = 3,

		[EnumMember]
		Ignored = 4

	}

}