using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class CharacterBase
    {
        [DataMember(Name = "membershipId")]
        public string MembershipId { get; set; }

        [DataMember(Name = "membershipType")]
        public int MembershipType { get; set; }

        [DataMember(Name = "characterId")]
        public string CharacterId { get; set; }

        [DataMember(Name = "dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }

        [DataMember(Name = "minutesPlayedThisSession")]
        public string MinutesPlayedThisSession { get; set; }

        [DataMember(Name = "minutesPlayedTotal")]
        public string MinutesPlayedTotal { get; set; }

        [DataMember(Name = "powerLevel")]
        public int PowerLevel { get; set; }

        [DataMember(Name = "raceHash")]
        public long RaceHash { get; set; }

        [DataMember(Name = "genderHash")]
        public object GenderHash { get; set; }

        [DataMember(Name = "classHash")]
        public object ClassHash { get; set; }

        [DataMember(Name = "currentActivityHash")]
        public long CurrentActivityHash { get; set; }

        [DataMember(Name = "lastCompletedStoryHash")]
        public int LastCompletedStoryHash { get; set; }

        [DataMember(Name = "grimoireScore")]
        public int GrimoireScore { get; set; }

        [DataMember(Name = "genderType")]
        public int GenderType { get; set; }

        [DataMember(Name = "classType")]
        public int ClassType { get; set; }

        [DataMember(Name = "buildStatGroupHash")]
        public object BuildStatGroupHash { get; set; }

        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }

        [DataMember(Name = "customization")]
        public Customization Customization { get; set; }

        [DataMember(Name = "peerView")]
        public PeerView PeerView { get; set; }

        public CharacterBase() {}

        public CharacterBase(JObject j)
        {
            MembershipId = j["characterBase"]["membershipId"].Value<string>();
            MembershipType = j["characterBase"]["membershipType"].Value<int>();
            CharacterId = j["characterBase"]["characterId"].Value<string>();
            DateLastPlayed = j["characterBase"]["dateLastPlayed"].Value<DateTime>();
            MinutesPlayedThisSession = j["characterBase"]["minutesPlayedThisSession"].Value<string>();
            MinutesPlayedTotal = j["characterBase"]["minutesPlayedTotal"].Value<string>();
            PowerLevel = j["characterBase"]["powerLevel"].Value<int>();
            RaceHash = j["characterBase"]["raceHash"].Value<long>();
            GenderHash = j["characterBase"]["genderHash"].Value<object>();
            ClassHash = j["characterBase"]["classHash"].Value<object>();
            CurrentActivityHash = j["characterBase"]["currentActivityHash"].Value<long>();
            LastCompletedStoryHash = j["characterBase"]["lastCompletedStoryHash"].Value<int>();
            GrimoireScore = j["characterBase"]["grimoireScore"].Value<int>();
            GenderType = j["characterBase"]["genderType"].Value<int>();
            ClassType = j["characterBase"]["classType"].Value<int>();
            BuildStatGroupHash = j["characterBase"]["buildStatGroupHash"].Value<object>();

            Stats = new Stats(j);
        }
    }
}
