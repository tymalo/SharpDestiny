using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class DefaultDye
    {

        [DataMember(Name="channelHash")]
        public int ChannelHash { get; set; }

        [DataMember(Name="dyeHash")]
        public int DyeHash { get; set; }
    }
}