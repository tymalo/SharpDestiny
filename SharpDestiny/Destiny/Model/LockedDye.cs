using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class LockedDye
    {

        [DataMember(Name="channelHash")]
        public int ChannelHash { get; set; }

        [DataMember(Name="dyeHash")]
        public object DyeHash { get; set; }
    }
}