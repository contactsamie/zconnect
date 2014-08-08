using System.Collections.Generic;
using zconnect.Components;
using zconnect.SignComponents;

namespace zconnect
{
    public class ASign
    {
        public SignName Name { set; get; }

        /// <summary>
        ///     Adjacent signs - Adjacent signs are signs that fall next
        ///     to your own in the Zodiac. If you are a Libra, Virgo and
        ///     Scorpio are your adjacent signs. People with adjacent signs
        ///     often find that they have little in common and may even actively dislike each other.
        /// </summary>
        public List<SignName> AdjacentSigns { set; get; }

        public PersonalitiesAndCharacteristics PersonalitiesAndCharacteristics { set; get; }

        public SignName OppositeSign { set; get; }

        public Ruler RuledBy { set; get; }

        public OtherRepresentation OtherRepresentation { set; get; }

        public Definition Definition { set; get; }

        public QualityGroup QualityGroup { set; get; }
    }
}