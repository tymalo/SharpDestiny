
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Equipment
    {

        [DataMember(Name = "itemHash")]
        public object ItemHash { get; set; }

        [DataMember(Name = "dyes")]
        public IList<Dye> Dyes { get; set; }
    }
}