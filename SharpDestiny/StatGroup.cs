using System.Collections.Generic;
using System.Runtime.Serialization;
using BungieNetPlatform.Destiny;

namespace BungieNetPlatform
{
    public class StatGroup
    {
        [DataMember(Name = "statGroupHash")]
        public long StatGroupHash { get; set; }

        [DataMember(Name = "maximumValue")]
        public int MaximumValue { get; set; }

        [DataMember(Name = "uiPosition")]
        public int UiPosition { get; set; }

        [DataMember(Name = "scaledStats")]
        public IList<ScaledStat> ScaledStats { get; set; }

        [DataMember(Name = "overrides")]
        public Overrides Overrides { get; set; }
    }
}
