
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Dye
    {

        [DataMember(Name = "channelHash")]
        public object ChannelHash { get; set; }

        [DataMember(Name = "dyeHash")]
        public object DyeHash { get; set; }
    }
}