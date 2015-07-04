using System.Runtime.Serialization;
using SharpDestiny.Common;

namespace SharpDestiny.Destiny.Enums {

	[DataContract]
	public enum DestinyDamageType {

		[EnumMember]
        [DisplayText("None")]
		None = 0,

		[EnumMember]
        [DisplayText("Kinetic")]
		Kinetic = 1,

		[EnumMember]
        [DisplayText("Arc")]
		Arc = 2,

		[EnumMember]
        [DisplayText("Solar")]
		Solar = 3,

		[EnumMember]
        [DisplayText("Void")]
		Void = 4,

		[EnumMember]
        [DisplayText("Raid")]
		Raid = 5
	}
}