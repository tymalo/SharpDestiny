using System.Collections.Generic;
using System.Runtime.Serialization;
using BungieNetPlatform.Destiny;

namespace BungieNetPlatform
{
    public class TalentGrid
    {
        [DataMember(Name = "gridHash")]
        public int GridHash { get; set; }

        [DataMember(Name = "maxGridLevel")]
        public int MaxGridLevel { get; set; }

        [DataMember(Name = "gridLevelPerColumn")]
        public int GridLevelPerColumn { get; set; }

        [DataMember(Name = "progressionHash")]
        public long ProgressionHash { get; set; }

        [DataMember(Name = "calcMaxGridLevel")]
        public int CalcMaxGridLevel { get; set; }

        [DataMember(Name = "calcProgressToMaxLevel")]
        public int CalcProgressToMaxLevel { get; set; }

        [DataMember(Name = "nodes")]
        public IList<Node> Nodes { get; set; }
    }
}
