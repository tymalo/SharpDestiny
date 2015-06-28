using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class PrimaryBaseStat
    {

        [DataMember(Name="statHash")]
        public int StatHash { get; set; }

        [DataMember(Name="value")]
        public int Value { get; set; }

        [DataMember(Name="minimum")]
        public int Minimum { get; set; }

        [DataMember(Name="maximum")]
        public int Maximum { get; set; }
    }
}