using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Equippable
    {

        [DataMember(Name="items")]
        public IList<Item> Items { get; set; }

        [DataMember(Name="bucketHash")]
        public object BucketHash { get; set; }
    }
}