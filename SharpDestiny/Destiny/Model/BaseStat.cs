using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class BaseStat
    {

        [DataMember(Name="statHash")]
        public object StatHash { get; set; }

        [DataMember(Name="value")]
        public int Value { get; set; }

        [DataMember(Name="minimum")]
        public int Minimum { get; set; }

        [DataMember(Name="maximum")]
        public int Maximum { get; set; }
    }
}