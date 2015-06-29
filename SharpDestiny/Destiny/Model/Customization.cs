
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Customization
    {

        [DataMember(Name = "personality")]
        public object Personality { get; set; }

        [DataMember(Name = "face")]
        public object Face { get; set; }

        [DataMember(Name = "skinColor")]
        public int SkinColor { get; set; }

        [DataMember(Name = "lipColor")]
        public long LipColor { get; set; }

        [DataMember(Name = "eyeColor")]
        public long EyeColor { get; set; }

        [DataMember(Name = "hairColor")]
        public long HairColor { get; set; }

        [DataMember(Name = "featureColor")]
        public object FeatureColor { get; set; }

        [DataMember(Name = "decalColor")]
        public long DecalColor { get; set; }

        [DataMember(Name = "wearHelmet")]
        public bool WearHelmet { get; set; }

        [DataMember(Name = "hairIndex")]
        public int HairIndex { get; set; }

        [DataMember(Name = "featureIndex")]
        public int FeatureIndex { get; set; }

        [DataMember(Name = "decalIndex")]
        public int DecalIndex { get; set; }
    }
}