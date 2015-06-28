using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;
using SharpDestiny.Responses;

namespace SharpDestiny.Platform.Response {

	[DataContract]
	public class GetTopicsResponse : QueryableResponse {

		[DataMember]
		public ICollection<Post> RelatedPosts;

		[DataMember]
		public ICollection<User> Authors;

		[DataMember]
		public ICollection<Group> Groups;

		[DataMember]
		public ICollection<Tag> SearchedTags;

		[DataMember]
		public ICollection<Post> Results;


		public GetTopicsResponse(JObject j) : base(j) {

			if(j["Response"] != null) {

				RelatedPosts = new List<Post>();
				Authors = new List<User>();
				Groups = new List<Group>();
				SearchedTags = new List<Tag>();
				Results = new List<Post>();

				foreach(JObject rp in j["Response"]["relatedPosts"]) {
					RelatedPosts.Add(new Post(rp));
				}

				foreach(JObject a in j["Response"]["authors"]) {
					Authors.Add(new User(a));
				}

				foreach(JObject g in j["Response"]["groups"]) {
					Groups.Add(new Group(g));
				}

				foreach(JObject r in j["Response"]["results"]) {
					Results.Add(new Post(r));
				}
			}
		}
	}
}
