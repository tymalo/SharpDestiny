using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using SharpDestiny.Platform.Enums;
using SharpDestiny.Platform.Model;
using SharpDestiny.Platform.Response;

namespace SharpDestiny.Platform
{
    [ServiceContract]
    public interface IBungiePlatform
    {
        [OperationContract]
        Task<GetTopicsResponse> GetTopics(
            RequestingUser u,
            IEnumerable<Tag> tags = null,
            int? page = null,
            int? groupId = null,
            bool asUser = false,
            ForumTopicsCategoryFilters category = ForumTopicsCategoryFilters.None,
            ForumTopicsSort sort = ForumTopicsSort.Latest,
            ForumTopicsQuickDate date = ForumTopicsQuickDate.LastYear,
            int itemsPerPage = BungieNet.ForumItemsPerPage);

        [OperationContract]
        Task<GroupResponse> GetGroup(
            RequestingUser u,
            int groupId);

        [OperationContract]
        Task<ConversationResponse> GetConversation(
            RequestingUser u,
            int conversationId,
            int page = 1);

        [OperationContract]
        Task<CreatePostResponse> CreateTopic(
            RequestingUser u,
            string subject,
            string body,
            string urlOrImage = null,
            int? groupId = null,
            Tag tagCategory = null,
            IEnumerable<Tag> tags = null);
		
        [OperationContract]
        Task<CreatePostResponse> PostReply(
            RequestingUser u,
            int parentPostId,
            string body,
            string media = "",
            int? groupId = null);

        [OperationContract]
        Task<SaveMessageResponse> WriteToWall(
            RequestingUser u,
            string body,
            int conversationId,
            string subject);

        [OperationContract]
        Task<GetCountsResponse> GetCounts(
            RequestingUser u);

        [OperationContract]
        Task<GetNotificationsResponse> CheckNotifications(
            RequestingUser u);

        [OperationContract]
        Task<CurrentUserResponse> GetCurrentUser(
            RequestingUser u);

        [OperationContract]
        Task<GetMessagesResponse> GetMessages(
            RequestingUser u,
            int page = 1);

        [OperationContract]
        Task<FollowersResponse> GetFollowers(
            RequestingUser u,
            int memberId,
            int page = 1,
            int itemsPerPage = 50);

        [OperationContract]
        Task<UserResponse> GetUserById(
            RequestingUser u,
            int memberId);

        [OperationContract]
        Task<UsersPagedResponse> SearchUsersPaged(
                  RequestingUser u,
            string gamerTag,
            int page =1);




    }
}