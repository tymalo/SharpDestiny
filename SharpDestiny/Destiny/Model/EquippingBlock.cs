using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class EquippingBlock
    {

        [DataMember(Name="weaponSandboxPatternIndex")]
        public int WeaponSandboxPatternIndex { get; set; }

        [DataMember(Name="gearArtArrangementIndex")]
        public int GearArtArrangementIndex { get; set; }

        [DataMember(Name="defaultDyes")]
        public IList<object> DefaultDyes { get; set; }

        [DataMember(Name="lockedDyes")]
        public IList<object> LockedDyes { get; set; }

        [DataMember(Name="customDyes")]
        public IList<object> CustomDyes { get; set; }

        [DataMember(Name="customDyeExpression")]
        public CustomDyeExpression CustomDyeExpression { get; set; }

        [DataMember(Name="weaponPatternHash")]
        public int WeaponPatternHash { get; set; }
    }
}