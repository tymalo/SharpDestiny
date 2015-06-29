using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;
using SharpDestiny.Common;

namespace SharpDestiny.Platform.Model {

	[DataContract]
	public class UsersPaged 
    {
        [DataMember]
        public string TotalResults;

        [DataMember]
        public bool UseTotalResults;

        [DataMember]
        public bool HasMore;

        [DataMember]
        public Query Query;

        [DataMember]
        public ICollection<User> Users;

		public UsersPaged() {
		}
        public UsersPaged(JObject j)
        {
            Users = new List<User>();

            TotalResults = j["totalResults"].Value<string>();
            UseTotalResults = j["useTotalResults"].Value<bool>();
            HasMore = j["hasMore"].Value<bool>();
            j["results"].Cast<JObject>().ForEach(p => Users.Add(new User(p)));

            if (j["query"] != null)
            {
                Query = new Query(j["query"].Value<JObject>());
            }
		}
	}
}
