using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDestiny.Destiny;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Platform;
using SharpDestiny.Platform.Response;


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
            _bungiePlatform = new Platform.BungiePlatform();
        }

        [TestMethod]
        public void WillFindDestinyAccount()
        {
            DestinyAccount destinyAccount = new DestinyAccount();

            //http://www.bungie.net/platform/User/SearchUsersPaged/superg00dadvice/1/
            var displayName = "dddddddddd";

            Task<UsersPagedResponse> query = _bungiePlatform.SearchUsersPaged(null,displayName, 1);
            UsersPagedResponse response = query.Result;

            if (response.UsersPaged.Users.Any())
            {
                var user = response.UsersPaged.Users.First();

                Task<BungieAccountResponse> _bungieAccountResponse = _destinyPlatform.BungieAccount(user.MemberId);

                if (_bungieAccountResponse.Result.BungieAccount.DestinyAccounts.Any())
                {
                    destinyAccount = _bungieAccountResponse.Result.BungieAccount.DestinyAccounts.First();

                    var characterId = destinyAccount.Characters.First().CharacterId;
                }
            }
            Assert.IsNotNull(destinyAccount);
        }

        [TestMethod]
        public void WillLoadCharacterInventory()
        {
            var accountId = "4611686018428828459";
            var charcaterId = "2305843009216514616";

            var itemsResponse = _destinyPlatform.GetCharacterInventory(accountId, charcaterId);

            ICollection<Item> items = itemsResponse.Result.Items;

            Assert.IsTrue(items.Count > 0);
        }
    }
}
