using System.ServiceModel;
using System.Threading.Tasks;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform.Response;

namespace SharpDestiny.Destiny
{
    [ServiceContract]
    public interface IDestinyPlatform
    {
        [OperationContract]
        Task<AccountResponse> Account(int membershipType,string membershipId);

        [OperationContract]
        Task<MembershipResponse> GetMembershipIdByDisplayName(int membershipType, string displayName);

        [OperationContract]
        Task<BungieAccountResponse> BungieAccount(int membershipId);

        [OperationContract]
        Task<CharacterInventoryResponse> GetCharacterInventory(string accountId, string characterId);
    }
}
