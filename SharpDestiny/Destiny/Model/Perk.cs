using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Perk
    {

        [DataMember(Name="iconPath")]
        public string IconPath { get; set; }

        [DataMember(Name="perkHash")]
        public int PerkHash { get; set; }

        [DataMember(Name="isActive")]
        public bool IsActive { get; set; }
    }
}