using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Step
    {

        [DataMember(Name="stepOperator")]
        public int StepOperator { get; set; }

        [DataMember(Name="flagHash")]
        public int FlagHash { get; set; }
    }
}