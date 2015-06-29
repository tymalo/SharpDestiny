using System.Text;

namespace SharpDestiny.Platform.Model {
	public class ForumReplyNotification {

		public User Replier;
		public int ReplyCount;
		public int PostId;

		public override string ToString() {

			StringBuilder sb = new StringBuilder();

			if(ReplyCount == 1) {
				sb.AppendFormat("{0} replied", Replier.DisplayName);
			}
			else {
				sb.AppendFormat(
					"{0} new repl{1}",
					ReplyCount,
					ReplyCount != 1 ? "ies" : "y"
				);
			}
			sb.AppendFormat(" to your post ({0})", PostId);

			return sb.ToString();

		}
	}
}
