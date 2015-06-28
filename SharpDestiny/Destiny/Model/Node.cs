using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class Node
    {

        [DataMember(Name="isActivated")]
        public bool IsActivated { get; set; }

        [DataMember(Name="stepIndex")]
        public int StepIndex { get; set; }
    }
}