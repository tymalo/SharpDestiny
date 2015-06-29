using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDestiny.Destiny;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform;
using SharpDestiny.Platform.Response;

namespace SharpDestiny.Tests
{
    [TestClass]
    public class When_Looking_For_User
    {
        private static IPlatformDestiny _platformDestiny;
        private static IPlatform _platform;
        
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            _platformDestiny = new PlatformDestiny();
            _platform = new Platform.Platform();
        }

        [TestMethod]
        public void WillFindDestinyAccount()
        {
            DestinyAccount destinyAccount = new DestinyAccount();

            //http://www.bungie.net/platform/User/SearchUsersPaged/superg00dadvice/1/
            var displayName = "SuperG00dAdvice";

            var query = _platform.SearchUsersPaged(null,displayName, 1);
            UsersPagedResponse response = query.Result;

            if (response.UsersPaged.Users.Any())
            {
                var user = response.UsersPaged.Users.First();

                Task<BungieAccountResponse> _bungieAccountResponse = _platformDestiny.BungieAccount(user.MemberId);

                destinyAccount = _bungieAccountResponse.Result.BungieAccount.DestinyAccounts.First();

                var characterId = destinyAccount.Characters.First().CharacterId;

            }
            Assert.IsNotNull(destinyAccount);
        }

        [TestMethod]
        public void WillLoadCharacterInventory()
        {
            var accountId = "4611686018428828459";
            var charcaterId = "2305843009216514616";

            var items = _platformDestiny.GetCharacterInventory(accountId, charcaterId);
        }
    }
}
