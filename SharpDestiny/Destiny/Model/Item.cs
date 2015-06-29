using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "itemHash")]
        public long ItemHash { get; set; }

        [DataMember(Name = "bindStatus")]
        public int BindStatus { get; set; }

        [DataMember(Name = "isEquipped")]
        public bool IsEquipped { get; set; }

        [DataMember(Name = "itemInstanceId")]
        public string ItemInstanceId { get; set; }

        [DataMember(Name = "itemLevel")]
        public int ItemLevel { get; set; }

        [DataMember(Name = "stackSize")]
        public int StackSize { get; set; }

        [DataMember(Name = "qualityLevel")]
        public int QualityLevel { get; set; }

        [DataMember(Name = "stats")]
        public IList<Stat> Stats { get; set; }

        [DataMember(Name = "primaryStat")]
        public PrimaryStat PrimaryStat { get; set; }

        [DataMember(Name = "canEquip")]
        public bool CanEquip { get; set; }

        [DataMember(Name = "equipRequiredLevel")]
        public int EquipRequiredLevel { get; set; }

        [DataMember(Name = "unlockFlagHashRequiredToEquip")]
        public long UnlockFlagHashRequiredToEquip { get; set; }

        [DataMember(Name = "cannotEquipReason")]
        public int CannotEquipReason { get; set; }

        [DataMember(Name = "damageType")]
        public int DamageType { get; set; }

        [DataMember(Name = "damageTypeNodeIndex")]
        public int DamageTypeNodeIndex { get; set; }

        [DataMember(Name = "damageTypeStepIndex")]
        public int DamageTypeStepIndex { get; set; }

        [DataMember(Name = "progression")]
        public Progression Progression { get; set; }

        [DataMember(Name = "talentGridHash")]
        public int TalentGridHash { get; set; }

        [DataMember(Name = "nodes")]
        public IList<Node> Nodes { get; set; }

        [DataMember(Name = "useCustomDyes")]
        public bool UseCustomDyes { get; set; }

        [DataMember(Name = "artRegions")]
        public ArtRegions ArtRegions { get; set; }

        [DataMember(Name = "isEquipment")]
        public bool IsEquipment { get; set; }

        [DataMember(Name = "isGridComplete")]
        public bool IsGridComplete { get; set; }

        [DataMember(Name = "perks")]
        public IList<Perk> Perks { get; set; }

        [DataMember(Name = "location")]
        public int Location { get; set; }

        [DataMember(Name = "transferStatus")]
        public int TransferStatus { get; set; }
    }
}
