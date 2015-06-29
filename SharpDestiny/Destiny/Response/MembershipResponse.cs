using Newtonsoft.Json.Linq;
using SharpDestiny.Destiny.Model;

namespace SharpDestiny.Destiny.Response
{
    public class MembershipResponse: Common.Response
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
