using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum ForumPostSort {

		[EnumMember]
		Default = 0,

		[EnumMember]
		OldestFirst = 1

	}

}