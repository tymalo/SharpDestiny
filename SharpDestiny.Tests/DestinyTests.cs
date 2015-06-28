using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Platform.Model;
using SharpDestiny.Platform.Response;

namespace SharpDestiny.Tests
{
    [TestClass]
    public class DestinyTests
    {
        private static IPlatformDestiny _platformDestiny;
        private static IPlatform _platform;
        
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            _platformDestiny = new PlatformDestiny();
            _platform = new Platform.Model.Platform();
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
    }
}
