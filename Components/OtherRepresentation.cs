using System.Collections.Generic;
using zconnect.SignProperties;

namespace zconnect.Components
{
    public class OtherRepresentation
    {
        public OtherRepresentation()
        {
            Gemstones=new List<Gemstone>();
            BodyParts=new List<BodyPart>();
        }

        public StarStone StarStone { set; get; }

        public List<BodyPart> BodyParts { set; get; }

        public Metal Metal { set; get; }

        public SignDayOfWeek DayOfWeek { set; get; }

        public Color Color { set; get; }

        public List<Gemstone> Gemstones { set; get; }

        public Season Season { set; get; }


        public Symbol Symbol { set; get; }

        public Animal Animal { set; get; }
    }
}