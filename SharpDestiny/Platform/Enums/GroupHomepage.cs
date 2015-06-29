using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum GroupHomepage {

		[EnumMember]
		Wall = 0,

		[EnumMember]
		Forum = 1,

		[EnumMember]
		AllianceForm = 2

	}
}
