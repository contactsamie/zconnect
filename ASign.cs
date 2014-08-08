using System;
using System.Collections.Generic;

namespace zconnect
{
    /// <summary>
    ///     Same star sign - If you share the same sun sign as your partner,
    ///     i.e. he or she is a Gemini and so are you; you may well be too alike
    ///     for the relationship to work or be stimulating. Shared negative habits
    ///     and weaknesses can lead to conflict as they are over-emphasized in the relationship.
    /// </summary>
    public abstract class ASign
    {
        public int CommonYear = 2000;

        public string NegativeQualities { set; get; }

        public string PositiveQualities { set; get; }

        public string BodyPart { set; get; }

        public string Countries { set; get; }

        public string Cities { set; get; }

        public string Metal { set; get; }

        public string DayOfWeek { set; get; }

        public string Color { set; get; }

        public string Gemstone { set; get; }

        public string Season { set; get; }

        public int NumerologyNumber { set; get; }

        public string Symbol { set; get; }

        public abstract string Career { set; get; }

        public abstract string Relationships { set; get; }

        public abstract string Personality { set; get; }

        public List<ASign> Compatibles { set; get; }

        public ASign OppositeSign { set; get; }

        public abstract StartStone StartStone { set; get; }

        public abstract Ruler RuledBy { set; get; }

        public abstract string Animal { set; get; }

        public abstract DateTime FromDate { set; get; }

        public abstract DateTime ToDate { set; get; }

        public abstract string Name { set; get; }
    }
}