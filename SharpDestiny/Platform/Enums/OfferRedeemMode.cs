using System;
using System.Runtime.Serialization;

namespace SharpDestiny.Enums {

	[DataContract]
	public enum OfferRedeemMode {

		[EnumMember]
		Off = 0,

		[EnumMember]
		Unlock = 1,

		[EnumMember]
		Platform = 2,

		[EnumMember]
		Expired = 3,

		[EnumMember]
		Consumable = 4,

	}

}