using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum GroupSortBy {

		[EnumMember]
		Name = 0,

		[EnumMember]
		Date = 1,

		[EnumMember]
		Popularity = 2,

		[EnumMember]
		Id = 3

	}

}