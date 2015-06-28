using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum ContentSortby {

		[EnumMember]
		CreationDate = 0,

		[EnumMember]
		CmsPath = 1

	}

}