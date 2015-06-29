using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Enums {

	[DataContract]
	public enum SurveyCompletion {

		[EnumMember]
		None = 0,

		[EnumMember]
		UserResearchWebPageOne = 1,

		[EnumMember]
		UserResearchWebPageTwo = 2

	}

}