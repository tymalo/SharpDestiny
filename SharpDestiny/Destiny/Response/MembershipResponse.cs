using SharpDestiny.Destiny;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Responses.Destiny
{
    public class MembershipResponse: Response
    {
        public Membership Membership;

        public MembershipResponse(JObject j) : base(j)
        {
            Membership = new Membership();

            if (j["Response"] != null)
            {
                Membership = new Membership(j["Response"].Value<string>());
            }
        }
    }
}
