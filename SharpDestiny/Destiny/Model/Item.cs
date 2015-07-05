using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "itemHash")]
        public string ItemHash { get; set; }

        [DataMember(Name = "itemName")]
        public string ItemName { get; set; }

        [DataMember(Name = "itemDescription")]
        public string ItemDescription { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "secondaryIcon")]
        public string SecondaryIcon { get; set; }

        [DataMember(Name = "hasAction")]
        public bool HasAction { get; set; }

        [DataMember(Name = "deleteOnAction")]
        public bool DeleteOnAction { get; set; }

        [DataMember(Name = "tierTypeName")]
        public string TierTypeName { get; set; }

        [DataMember(Name = "tierType")]
        public int TierType { get; set; }

        [DataMember(Name = "itemTypeName")]
        public string ItemTypeName { get; set; }

        [DataMember(Name = "bucketTypeHash")]
        public string BucketTypeHash { get; set; }

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
        public string TalentGridHash { get; set; }

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

        public Item(JObject j)
        {
            Stats = new List<Stat>();
            Perks = new List<Perk>();

            ItemHash = j["itemHash"].Value<string>();
            ItemName = j["itemName"] != null ? j["itemName"].Value<string>() : null;
            ItemDescription = j["itemDescription"] != null ? j["itemDescription"].Value<string>() : null;
            Icon = j["icon"] != null ? j["icon"].Value<string>() : null;
            SecondaryIcon = j["secondaryIcon"] != null ? j["secondaryIcon"].Value<string>() : null;

            TierTypeName = j["tierTypeName"] != null ? j["tierTypeName"].Value<string>() : null;
            ItemTypeName = j["itemTypeName"] != null ? j["itemTypeName"].Value<string>() : null;
            BucketTypeHash = j["bucketTypeHash"] != null ? j["bucketTypeHash"].Value<string>() : null;
            TalentGridHash = j["talentGridHash"] != null ? j["talentGridHash"].Value<string>() : null;

            if (j["tierType"] != null)
            {
                TierType = j["tierType"].Value<int>();
            }

            if (j["damageType"] != null)
            {
                DamageType = j["damageType"].Value<int>();
            }

            if (j["stats"] != null)
            {
                j["stats"].ForEach(x =>
                {
                    if (x.Type == JTokenType.Property)
                    {
                        JObject jObj = x.First.Value<JObject>();
                        Stats.Add(new Stat(jObj));
                    }
                    if (x.Type == JTokenType.Object)
                    {
                        JObject jObj = x.Value<JObject>();
                        Stats.Add(new Stat(jObj));
                    }
                });
            }

            if (j["perks"] != null)
            {
                j["perks"].ForEach(x =>
                {
                    JToken token = x.Value<JToken>();

                    if (x.Type == JTokenType.Property)
                    {
                        var jObj = x.Value<JObject>();
                        Perks.Add(new Perk(jObj));
                    }
                    if (x.Type == JTokenType.Object)
                    {
                        JToken t = token;
                        Perks.Add(new Perk(t.Value<JObject>()));
                    }
                });
            }
        }
    }
}