using Newtonsoft.Json.Linq;
using SharpCommon.Extension;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class TalentGrid
    {
        [DataMember(Name = "gridHash")]
        public string GridHash { get; set; }

        [DataMember(Name = "maxGridLevel")]
        public int MaxGridLevel { get; set; }

        [DataMember(Name = "gridLevelPerColumn")]
        public int GridLevelPerColumn { get; set; }

        [DataMember(Name = "progressionHash")]
        public string ProgressionHash { get; set; }

        [DataMember(Name = "calcMaxGridLevel")]
        public int CalcMaxGridLevel { get; set; }

        [DataMember(Name = "calcProgressToMaxLevel")]
        public int CalcProgressToMaxLevel { get; set; }

        [DataMember(Name = "nodes")]
        public IList<Node> Nodes { get; set; }

        public TalentGrid(JObject j)
        {
            Nodes = new List<Node>();

            GridHash = j["gridHash"] != null ? j["gridHash"].Value<string>() : null;

            if (j["maxGridLevel"] != null) 
            {
                MaxGridLevel = j["maxGridLevel"].Value<int>();
            }
            if (j["gridLevelPerColumn"] != null)
            {
                GridLevelPerColumn = j["gridLevelPerColumn"].Value<int>();
            }

            ProgressionHash = j["progressionHash"] != null ? j["progressionHash"].Value<string>() : null;

            if (j["calcMaxGridLevel"] != null)
            {
                CalcMaxGridLevel = j["calcMaxGridLevel"].Value<int>();
            }
            if (j["calcProgressToMaxLevel"] != null)
            {
                CalcProgressToMaxLevel = j["calcProgressToMaxLevel"].Value<int>();
            }
            if (j["nodes"] != null)
            {
                j["nodes"].ForEach(x =>
                {
                    JObject jObj = x.Value<JObject>();
                    Nodes.Add(new Node(jObj));
                });
            }
        }
    }
}