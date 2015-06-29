using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum ForumPostSort {

		[EnumMember]
		Default = 0,

		[EnumMember]
		OldestFirst = 1

	}

}