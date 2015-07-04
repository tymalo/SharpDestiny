using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Character
    {
        [DataMember(Name = "characterId")]
        public string CharacterId { get; set; }

        [DataMember(Name = "raceHash")]
        public object RaceHash { get; set; }

        [DataMember(Name = "genderHash")]
        public object GenderHash { get; set; }

        [DataMember(Name = "classHash")]
        public object ClassHash { get; set; }

        [DataMember(Name = "race")]
        public Race Race { get; set; }

        [DataMember(Name = "gender")]
        public Gender Gender { get; set; }

        [DataMember(Name = "characterClass")]
        public CharacterClass CharacterClass { get; set; }

        [DataMember(Name = "emblemPath")]
        public string EmblemPath { get; set; }

        [DataMember(Name = "backgroundPath")]
        public string BackgroundPath { get; set; }

        [DataMember(Name = "emblemHash")]
        public object EmblemHash { get; set; }

        [DataMember(Name = "characterLevel")]
        public int CharacterLevel { get; set; }

        [DataMember(Name = "baseCharacterLevel")]
        public int BaseCharacterLevel { get; set; }

        [DataMember(Name = "isPrestigeLevel")]
        public bool IsPrestigeLevel { get; set; }

        [DataMember(Name = "percentToNextLevel")]
        public double PercentToNextLevel { get; set; }

        [DataMember(Name = "characterBase")]
        public CharacterBase CharacterBase { get; set; }

        [DataMember(Name = "levelProgression")]
        public LevelProgression LevelProgression { get; set; }

        public Character(JObject j)
        {
            if (j["characterLevel"] != null)
            {
                CharacterLevel = j["characterLevel"].Value<int>();
            }

            if (j["characterId"] != null)
            {
                CharacterId = j["characterId"].Value<string>();
            }

            if (j["characterClass"] != null)
            {
                CharacterClass =  new CharacterClass(j["characterClass"].Value<JObject>());
            }
        

            if (j["characterBase"] != null)
            {
                CharacterId = j["characterBase"]["characterId"] != null ? j["characterBase"]["characterId"].Value<string>() : null;
                CharacterClass = j["characterBase"]["characterClass"] != null ? new CharacterClass(j["characterBase"]["characterClass"].Value<JObject>()) : null;
            }

       

            //if (j["emblemPath"] != null) {
            //    EmblemPath = j["emblemPath"].Value<string>();
            //}
 
            //BackgroundPath = j["backgroundPath"].Value<string>();
            //EmblemHash = j["emblemHash"].Value<object>();
            //CharacterLevel = j["characterLevel"].Value<int>();
            //BaseCharacterLevel = j["characterLevel"].Value<int>();
            //IsPrestigeLevel = j["isPrestigeLevel"].Value<bool>();
            //PercentToNextLevel = j["isPrestigeLevel"].Value<double>();

            //CharacterBase = new CharacterBase(j);
            //LevelProgression = new LevelProgression(j);
        }
    }
}
