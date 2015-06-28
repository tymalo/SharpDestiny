using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Destiny
{
    public class ScaledStat
    {
        [DataMember(Name = "statHash")]
        public long StatHash { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        [DataMember(Name = "displayAsNumeric")]
        public bool DisplayAsNumeric { get; set; }

        [DataMember(Name = "displayInterpolation")]
        public IList<DisplayInterpolation> DisplayInterpolation { get; set; }
    }
}
