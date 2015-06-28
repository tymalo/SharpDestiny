using System.Runtime.Serialization;

namespace SharpDestiny.Enums {
	[DataContract]
	public enum ChatSecurity {

		[EnumMember]
		AllMembers = 0,

		[EnumMember]
		AdminsOnly = 1

	}
}
