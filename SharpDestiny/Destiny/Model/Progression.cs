using System.Runtime.Serialization;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Progression
    {
        [DataMember(Name="dailyProgress")]
        public int DailyProgress { get; set; }

        [DataMember(Name="weeklyProgress")]
        public int WeeklyProgress { get; set; }

        [DataMember(Name="currentProgress")]
        public int CurrentProgress { get; set; }

        [DataMember(Name="level")]
        public int Level { get; set; }

        [DataMember(Name="step")]
        public int Step { get; set; }

        [DataMember(Name="progressToNextLevel")]
        public int ProgressToNextLevel { get; set; }

        [DataMember(Name="nextLevelAt")]
        public int NextLevelAt { get; set; }

        [DataMember(Name="progressionHash")]
        public int ProgressionHash { get; set; }
    }
}