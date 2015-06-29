using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Platform.Response
{
    [DataContract]
    public class UsersPagedResponse : Common.Response
    {
        [DataMember]
        public UsersPaged UsersPaged;

        public UsersPagedResponse(JObject j) : base(j)
        {
            if (j["Response"] != null)
            {
                UsersPaged = new UsersPaged(j["Response"].Value<JObject>());
            }
        }
    }
}
