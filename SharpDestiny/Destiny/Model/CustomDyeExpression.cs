using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class CustomDyeExpression
    {

        [DataMember(Name="steps")]
        public IList<object> Steps { get; set; }
    }
}