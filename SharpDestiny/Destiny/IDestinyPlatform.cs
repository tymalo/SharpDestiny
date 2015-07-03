using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using SharpDestiny.Destiny.Enums;
using SharpDestiny.Destiny.Model;
using SharpDestiny.Destiny.Response;
using SharpDestiny.Platform.Response;

namespace SharpDestiny.Destiny
{
    [ServiceContract]
    public interface IDestinyPlatform
    {
        [OperationContract]
        Task<DestinyAccountResponse> DestinyAccount(int membershipType,string membershipId);

        [OperationContract]
        Task<MembershipResponse> GetMembershipIdByDisplayName(int membershipType, string displayName);

        [OperationContract]
        Task<BungieAccountResponse> BungieAccount(int membershipId);

        [OperationContract]
        Task<CharacterInventoryResponse> GetCharacterInventory(string accountId, string characterId);

        /// <summary>
        /// Searches for Charcater items by supplying the initial character response json,
        ///  
        /// </summary>
        /// <param name="characterInventory">GetCharacterInventory(string accountId, string characterId)</param>
        /// <param name="bucketName">DestinyBucketNames.PrimaryWeapons</param>
        /// <returns></returns>
        IList<Item> FindCharacterItemsByBucketName(CharacterInventoryResponse characterInventory,DestinyBucketNames bucketName);

        DestinyAccountCharacters FindDestinyAccountCharacters(string gamertag);
    }
}
