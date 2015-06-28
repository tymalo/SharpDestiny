using System.ServiceModel;
using System.Threading.Tasks;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform.Response;
using SharpDestiny.Responses.Destiny;

namespace SharpDestiny.Destiny
{
    [ServiceContract]
    public interface IPlatformDestiny
    {
        [OperationContract]
        Task<AccountResponse> Account(int membershipType,string membershipId);

        [OperationContract]
        Task<MembershipResponse> GetMembershipIdByDisplayName(int membershipType, string displayName);

        [OperationContract]
        Task<PlayerResponse> SearchPlayer(int membershipType, string userName);

        [OperationContract]
        Task<BungieAccountResponse> BungieAccount(int membershipId);

        [OperationContract]
        Task<MembershipResponse> GetCharacterInventory(string accountId, string characterId);
    }
}
