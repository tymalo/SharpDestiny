using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum ActivityAggregationType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Activities = 1,

		[EnumMember]
		Followers = 2

	}

}