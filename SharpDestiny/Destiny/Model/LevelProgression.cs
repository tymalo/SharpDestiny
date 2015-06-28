using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny
{
    [DataContract]
    public class LevelProgression
    {
        [DataMember(Name = "dailyProgress")]
        public int DailyProgress { get; set; }

        [DataMember(Name = "weeklyProgress")]
        public int WeeklyProgress { get; set; }

        [DataMember(Name = "currentProgress")]
        public int CurrentProgress { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "step")]
        public int Step { get; set; }

        [DataMember(Name = "progressToNextLevel")]
        public int ProgressToNextLevel { get; set; }

        [DataMember(Name = "nextLevelAt")]
        public int NextLevelAt { get; set; }

        [DataMember(Name = "progressionHash")]
        public int ProgressionHash { get; set; }

        public LevelProgression() {}

        public LevelProgression(JObject j)
        {
            DailyProgress = j["levelProgression"]["dailyProgress"].Value<int>();
            WeeklyProgress = j["levelProgression"]["weeklyProgress"].Value<int>();
            CurrentProgress = j["levelProgression"]["currentProgress"].Value<int>();
            Level = j["levelProgression"]["level"].Value<int>();
            Step = j["levelProgression"]["step"].Value<int>();
            Level = j["levelProgression"]["level"].Value<int>();
            ProgressToNextLevel = j["levelProgression"]["progressToNextLevel"].Value<int>();
            NextLevelAt = j["levelProgression"]["nextLevelAt"].Value<int>();
            ProgressionHash = j["levelProgression"]["progressionHash"].Value<int>();

        }
    }
}