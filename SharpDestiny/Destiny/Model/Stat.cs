using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Stat
    {

        [DataMember(Name="statHash")]
        public object StatHash { get; set; }

        [DataMember(Name="value")]
        public int Value { get; set; }

        [DataMember(Name="maximumValue")]
        public int MaximumValue { get; set; }
    }
}