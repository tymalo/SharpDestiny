using System.Runtime.Serialization;

namespace BungieNetPlatform.Destiny
{
    [DataContract]
    public class DisplayInterpolation
    {

        [DataMember(Name = "value")]
        public int Value { get; set; }

        [DataMember(Name = "weight")]
        public int Weight { get; set; }
    }
}
