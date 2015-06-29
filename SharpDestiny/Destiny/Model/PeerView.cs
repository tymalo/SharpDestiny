using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class PeerView
    {

        [DataMember(Name = "equipment")]
        public IList<Equipment> Equipment { get; set; }
    }
}