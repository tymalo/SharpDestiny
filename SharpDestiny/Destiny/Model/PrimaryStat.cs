using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class PrimaryStat
    {
        [DataMember(Name="statHash")]
        public long StatHash { get; set; }

        [DataMember(Name="value")]
        public int Value { get; set; }

        [DataMember(Name="maximumValue")]
        public int MaximumValue { get; set; }
    }
}