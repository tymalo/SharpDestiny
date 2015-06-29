﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpDestiny.Platform.Model;

namespace SharpDestiny.Platform.Response {

	[DataContract]
	public class GetNotificationsResponse : Common.Response {

		[DataMember]
		public int GroupActivityCount;

		[DataMember]
		public ICollection<Notification> Notifications;

		[DataMember]
		public int TagActivityCount;


		public GetNotificationsResponse(JObject j) : base(j) {

			if(j["Response"] != null) {

				GroupActivityCount = j["Response"]["groupActivityCount"].Value<int>();
				TagActivityCount = j["Response"]["tagActivityCount"].Value<int>();

				Notifications = new List<Notification>();
				foreach(JObject n in j["Response"]["notifications"]) {
					Notifications.Add(new Notification(n));
				}

			}

		}

	}
}
