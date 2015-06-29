using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Model
{
    [DataContract]
    public class CharacterClass
    {
        [DataMember(Name = "classHash")]
        public object ClassHash { get; set; }

        [DataMember(Name = "classType")]
        public int ClassType { get; set; }

        [DataMember(Name = "className")]
        public string ClassName { get; set; }

        [DataMember(Name = "classNameMale")]
        public string ClassNameMale { get; set; }

        [DataMember(Name = "classNameFemale")]
        public string ClassNameFemale { get; set; }

        [DataMember(Name = "classIdentifier")]
        public string ClassIdentifier { get; set; }

        [DataMember(Name = "mentorVendorIdentifier")]
        public string MentorVendorIdentifier { get; set; }
    }
}