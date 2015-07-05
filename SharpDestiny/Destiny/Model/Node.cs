using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Node
    {
        [DataMember(Name = "isActivated")]
        public bool IsActivated { get; set; }

        [DataMember(Name = "stepIndex")]
        public int StepIndex { get; set; }

        [DataMember(Name = "nodeIndex")]
        public int NodeIndex { get; set; }

        [DataMember(Name = "nodeHash")]
        public string NodeHash { get; set; }

        [DataMember(Name = "row")]
        public int Row { get; set; }

        [DataMember(Name = "column")]
        public int Column { get; set; }

        [DataMember(Name = "binaryPairNodeIndex")]
        public int BinaryPairNodeIndex { get; set; }

        [DataMember(Name = "autoUnlocks")]
        public bool AutoUnlocks { get; set; }

        [DataMember(Name = "lastStepRepeats")]
        public bool LastStepRepeats { get; set; }

        [DataMember(Name = "isRandom")]
        public bool IsRandom { get; set; }

        [DataMember(Name = "isRandomRepurchasable")]
        public bool IsRandomRepurchasable { get; set; }

        [DataMember(Name = "randomStartProgressionBarAtProgression")]
        public int RandomStartProgressionBarAtProgression { get; set; }

        [DataMember(Name = "steps")]
        public IList<Step> Steps { get; set; }

        public Node(JObject j)
        {
            IsActivated = j["IsActivated"] != null && j["IsActivated"].Value<bool>();

            if (j["stepIndex"] != null)
            {
                StepIndex = j["stepIndex"].Value<int>();
            }
            if (j["nodeIndex"] != null)
            {
                NodeIndex = j["nodeIndex"].Value<int>();
            }
            NodeHash = j["nodeHash"] != null ? j["nodeHash"].Value<string>() : null;
            
            if (j["row"] != null)
            {
                Row = j["row"].Value<int>();
            }
            if (j["column"] != null)
            {
                Column = j["column"].Value<int>();
            }
            if (j["binaryPairNodeIndex"] != null)
            {
                BinaryPairNodeIndex = j["binaryPairNodeIndex"].Value<int>();
            }
            if (j["autoUnlocks"] != null)
            {
                AutoUnlocks = j["autoUnlocks"].Value<bool>();
            }
            if (j["lastStepRepeats"] != null)
            {
                LastStepRepeats = j["lastStepRepeats"].Value<bool>();
            }
            if (j["isRandom"] != null)
            {
                IsRandom = j["isRandom"].Value<bool>();
            }
            if (j["isRandomRepurchasable"] != null)
            {
                IsRandomRepurchasable = j["isRandomRepurchasable"].Value<bool>();
            }
            if (j["randomStartProgressionBarAtProgression"] != null)
            {
                RandomStartProgressionBarAtProgression = j["randomStartProgressionBarAtProgression"].Value<int>();
            }

            Steps = new List<Step>();

            if (j["steps"] != null)
            {
                j["steps"].ForEach(x =>
                {
                    JObject jObj = x.Value<JObject>();
                    Steps.Add(new Step(jObj));
                });
            }
        }
    }
}