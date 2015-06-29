using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;
using SharpDestiny.Common;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Platform.Response {
	public class FollowersResponse : QueryableResponse {

		public ICollection<User> Followers;

		public FollowersResponse(JObject j) : base(j) {

			//This does not include other followin information, eg. dateFollowed
			Followers = new List<User>();

			if(j["Response"]["results"] != null) {
				j["Response"]["results"].ForEach(u =>Followers.Add(new User(Extensions.Value<JObject>(u["user"]))));
			}
		}
	}
}
