using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDestiny.Destiny;
using SharpDestiny.Destiny.Enums;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Destiny.Response;

namespace SharpDestiny.Tests
{
    [TestClass]
    public class When_Parsing_Gamer_Account
    {
        public static IDestinyPlatform DestinyPlatform;
        public static string DisplayName { get; set; }
        public static string CharcaterId { get; set; }
        public static string MembershipId { get; set; }
        public static int MembershiType { get; set; }

        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            DestinyPlatform = new DestinyPlatform();
            MembershiType = 2;

            ////GameCompanion
            //DisplayName = "GameCompanion";
            //MembershipId = "4611686018428828459";
            //CharcaterId = "2305843009216514616";

            //SuperG00dAdvice
            DisplayName = "SuperG00dAdvice";
            MembershipId = "4611686018438970787";
            CharcaterId = "2305843009264111518";
        }

        [TestMethod]
        public void Will_Find_Find_Destiny_Account_Characters()
        {
            var x = DestinyPlatform.FindDestinyAccountCharacters(2,DisplayName);
            Assert.AreEqual(x.MembershipId,MembershipId);
        }

        [TestMethod]
        public void Will_Load_Character_Inventory()
        {
            var itemsResponse = DestinyPlatform.GetCharacterInventory(MembershipId, CharcaterId);
            ICollection<Item> items = itemsResponse.Result.Items;
            Assert.IsTrue(items.Count > 0);
        }

        [TestMethod]
        public void Will_Find_Character_Items_By_Bucket_Name()
        {
            CharacterInventoryResponse characterInventory = DestinyPlatform.GetCharacterInventory(MembershipId, CharcaterId).Result;
            List<Item> primaries = DestinyPlatform.FindCharacterItemsByBucketName(characterInventory, DestinyBucketNames.PrimaryWeapons).ToList();
            Assert.IsTrue(primaries.Count > 0);
        }

        [TestMethod]
        public void Will_Load_Character_Items_With_Stats()
        {
            CharacterInventoryResponse characterInventory = DestinyPlatform.GetCharacterInventory(MembershipId, CharcaterId).Result;
            List<Item> primaries = DestinyPlatform.FindCharacterItemsByBucketName(characterInventory, DestinyBucketNames.PrimaryWeapons).ToList();
            Assert.IsTrue(primaries.Any(x=>x.Stats.Count >0));
        }

        [TestMethod]
        public void Will_Load_Character_Items_With_Perks()
        {
            CharacterInventoryResponse characterInventory = DestinyPlatform.GetCharacterInventory(MembershipId, CharcaterId).Result;
            List<Item> primaries = DestinyPlatform.FindCharacterItemsByBucketName(characterInventory, DestinyBucketNames.HeavyWeapons).ToList();
            Assert.IsTrue(primaries.Any(x => x.Perks.Count >0 ));
        }

        [TestMethod]
        public void Will_Load_Character_Items_With_Steps()
        {
            CharacterInventoryResponse characterInventory = DestinyPlatform.GetCharacterInventory(MembershipId, CharcaterId).Result;
            List<Item> primaries = DestinyPlatform.FindCharacterItemsByBucketName(characterInventory, DestinyBucketNames.HeavyWeapons).ToList();
            Assert.IsTrue(primaries.Any(x => x.Nodes.Count > 0 && x.Nodes.Any(n=>n.Steps.Count >0)));
        }
    }
}
