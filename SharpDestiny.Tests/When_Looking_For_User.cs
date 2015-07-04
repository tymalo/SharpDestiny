using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDestiny.Destiny;
using SharpDestiny.Destiny.Enums;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform;


namespace SharpDestiny.Tests
{
    [TestClass]
    public class When_Looking_For_User
    {
        private static IDestinyPlatform _destinyPlatform;
        private static IBungiePlatform _bungiePlatform;
        
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            _destinyPlatform = new DestinyPlatform();
            _bungiePlatform = new BungiePlatform();
        }

        [TestMethod]
        public void WillFindFindDestinyAccountCharactersGameCompanion()
        {
            var displayName = "GameCompanion";
            var membershipId = "4611686018428828459";

            var x = _destinyPlatform.FindDestinyAccountCharacters(2,displayName);

            Assert.AreEqual(x.MembershipId,membershipId);
        }

        [TestMethod]
        public void WillFindFindDestinyAccountCharactersAccountSuperG00dAdvice()
        {
            var displayName = "SuperG00dAdvice";
            var membershipId = "4611686018438970787";

            var x = _destinyPlatform.FindDestinyAccountCharacters(2, displayName);

            Assert.AreEqual(x.MembershipId, membershipId);
        }

        [TestMethod]
        public void WillLoadCharacterInventory()
        {
            var memebrshipId = "4611686018428828459";
            var charcaterId = "2305843009216514616";

            var itemsResponse = _destinyPlatform.GetCharacterInventory(memebrshipId, charcaterId);

            ICollection<Item> items = itemsResponse.Result.Items;

            Assert.IsTrue(items.Count > 0);
        }

        [TestMethod]
        public void WillFindCharacterItemsByBucketName()
        {
            var memebrshipId = "4611686018428828459";
            var charcaterId = "2305843009216514616";

            CharacterInventoryResponse characterInventory = _destinyPlatform.GetCharacterInventory(memebrshipId, charcaterId).Result;

            List<Item> primaries = _destinyPlatform.FindCharacterItemsByBucketName(characterInventory, DestinyBucketNames.PrimaryWeapons).ToList();

            Assert.IsTrue(primaries.Count > 0);
        }
    }
}
