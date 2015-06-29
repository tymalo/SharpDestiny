using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Model
{
    [DataContract]
    public class Gender
    {
        [DataMember(Name = "genderHash")]
        public object GenderHash { get; set; }

        [DataMember(Name = "genderType")]
        public int GenderType { get; set; }

        [DataMember(Name = "genderName")]
        public string GenderName { get; set; }

        [DataMember(Name = "genderDescription")]
        public string GenderDescription { get; set; }
    }
}