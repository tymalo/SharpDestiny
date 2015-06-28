using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    public class Player
    {
        [DataMember]
        public string IconPath;

        [DataMember]
        public int MembershipType;

        [DataMember]
        public string MembershipId;

        [DataMember]
        public string DisplayName;
    }
}