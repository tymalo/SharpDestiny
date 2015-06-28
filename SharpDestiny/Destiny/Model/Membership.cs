using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Membership
    {
        [DataMember(Name = "membershipId")]
        public string MembershipId { get; set; }

        public Membership() { }

        public Membership(string id)
        {
            MembershipId = id;
        }
    }
}
