using System;
using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum ForumTypeEnum {

		[EnumMember]
		Public = 0,

		[EnumMember]
		News = 1,

		[EnumMember]
		Group = 2,

		[EnumMember]
		Alliance = 3

	}

}