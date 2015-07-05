using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Step
    {
        [DataMember(Name = "stepOperator")]
        public int StepOperator { get; set; }

        [DataMember(Name = "flagHash")]
        public int FlagHash { get; set; }

        [DataMember(Name = "stepIndex")]
        public int StepIndex { get; set; }

        [DataMember(Name = "nodeStepHash")]
        public string NodeStepHash { get; set; }

        [DataMember(Name = "nodeStepName")]
        public string NodeStepName { get; set; }

        [DataMember(Name = "nodeStepDescription")]
        public string NodeStepDescription { get; set; }

        [DataMember(Name = "interactionDescription")]
        public string InteractionDescription { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "damageType")]
        public int DamageType { get; set; }

        [DataMember(Name = "canActivateNextStep")]
        public bool CanActivateNextStep { get; set; }

        [DataMember(Name = "nextStepIndex")]
        public int NextStepIndex { get; set; }

        [DataMember(Name = "isNextStepRandom")]
        public bool IsNextStepRandom { get; set; }

        [DataMember(Name = "startProgressionBarAtProgress")]
        public int StartProgressionBarAtProgress { get; set; }

        [DataMember(Name = "affectsQuality")]
        public bool AffectsQuality { get; set; }

        [DataMember(Name = "trueStepIndex")]
        public int TrueStepIndex { get; set; }

        [DataMember(Name = "truePropertyIndex")]
        public int TruePropertyIndex { get; set; }

        [DataMember(Name = "affectsLevel")]
        public bool AffectsLevel { get; set; }

        [DataMember(Name = "perkHashes")]
        public IList<string> PerkHashes { get; set; }

        [DataMember(Name = "statHashes")]
        public IList<string> StatHashes { get; set; }

        [DataMember(Name = "stepGroups")]
        public StepGroup StepGroups { get; set; }

        [DataMember(Name = "activationRequirement")]
        public ActivationRequirement ActivationRequirement { get; set; }

        public Step(JObject j)
        {
            if (j["stepOperator"] != null)
            {
                StepOperator = j["stepOperator"].Value<int>();
            }
            if (j["flagHash"] != null)
            {
                FlagHash = j["flagHash"].Value<int>();
            }
            if (j["stepIndex"] != null)
            {
                StepIndex = j["stepIndex"].Value<int>();
            }

            NodeStepHash = j["nodeStepHash"] != null ? j["nodeStepHash"].Value<string>() : null;
            NodeStepName = j["nodeStepName"] != null ? j["nodeStepName"].Value<string>() : null;
            NodeStepDescription = j["nodeStepDescription"] != null ? j["nodeStepDescription"].Value<string>() : null;
            InteractionDescription = j["interactionDescription"] != null ? j["interactionDescription"].Value<string>() : null;
            Icon = j["icon"] != null ? j["icon"].Value<string>() : null;

            if (j["damageType"] != null)
            {
                DamageType = j["damageType"].Value<int>();
            }

            CanActivateNextStep = j["canActivateNextStep"] != null && j["canActivateNextStep"].Value<bool>();

            if (j["nextStepIndex"] != null)
            {
                NextStepIndex = j["nextStepIndex"].Value<int>();
            }

            IsNextStepRandom = j["isNextStepRandom"] != null && j["isNextStepRandom"].Value<bool>();

            if (j["startProgressionBarAtProgress"] != null)
            {
                StartProgressionBarAtProgress = j["startProgressionBarAtProgress"].Value<int>();
            }

            AffectsQuality = j["affectsQuality"] != null && j["affectsQuality"].Value<bool>();

            if (j["trueStepIndex"] != null)
            {
                TrueStepIndex = j["trueStepIndex"].Value<int>();
            }
            if (j["truePropertyIndex"] != null)
            {
                TruePropertyIndex = j["truePropertyIndex"].Value<int>();
            }

            AffectsLevel = j["affectsLevel"] != null && j["affectsLevel"].Value<bool>();

            PerkHashes = new List<string>();
            if (j["perkHashes"] != null)
            {
                j["perkHashes"].ForEach(x =>
                {
                    PerkHashes.Add(x.Value<string>());
                });
            }

            StatHashes = new List<string>();
            if (j["statHashes"] != null)
            {
                j["statHashes"].ForEach(x =>
                {
                    StatHashes.Add(x.Value<string>());
                });
            }
        }
    }
}