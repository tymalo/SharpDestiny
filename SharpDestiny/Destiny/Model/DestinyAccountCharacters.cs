using System.Collections.Generic;

namespace SharpDestiny.Destiny.Model
{
    public class DestinyAccountCharacters
    {
        public DestinyAccountCharacters()
        {
            Characters = new List<Character>();
        }

        public virtual string MembershipId { get; set; }
        public List<Character> Characters { get; set; }
    }
}
