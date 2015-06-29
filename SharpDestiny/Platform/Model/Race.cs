using System.Runtime.Serialization;

namespace SharpDestiny.Platform.Model
{
    [DataContract]
    public class Race
    {
        [DataMember(Name = "raceHash")]
        public object RaceHash { get; set; }

        [DataMember(Name = "raceType")]
        public int RaceType { get; set; }

        [DataMember(Name = "raceName")]
        public string RaceName { get; set; }

        [DataMember(Name = "raceNameMale")]
        public string RaceNameMale { get; set; }

        [DataMember(Name = "raceNameFemale")]
        public string RaceNameFemale { get; set; }
        
        [DataMember(Name = "raceDescription")]
        public string RaceDescription { get; set; }
    }
}