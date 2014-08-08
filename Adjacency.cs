using System.Collections.Generic;

namespace zconnect
{
    /// <summary>
    ///     Adjacent signs - Adjacent signs are signs that fall next
    ///     to your own in the Zodiac. If you are a Libra, Virgo and
    ///     Scorpio are your adjacent signs. People with adjacent signs
    ///     often find that they have little in common and may even actively dislike each other.
    /// </summary>
    public abstract class Adjacency
    {
        public List<ASign> Adjacents { set; get; }
    }
}