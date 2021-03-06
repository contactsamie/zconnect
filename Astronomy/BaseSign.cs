﻿using System.Collections.Generic;
using zconnect.Components;
using zconnect.SignProperties;

namespace zconnect.Astronomy
{
    public abstract class BaseSign : ASign
    {
        protected BaseSign()
        {
            Name = SignName.Unknown;
            Definition = new Definition(0, 0, 0, 0);
            Element = Element.UnknownElement;
            OppositeSign = SignName.Unknown;
            Rulers = Ruler.Unknown;
            QualityGroup = QualityGroup.UnknownQualityGroup;
            OtherRepresentation = new OtherRepresentation
            {
                Animal = Animal.Unknown,
                BodyParts = "",
                Color = Color.Unknown,
                DayOfWeek = SignDayOfWeek.Unknown,
                Gemstones = Gemstone.Unknown,
                Metal = Metal.Unknown,
                Season = Season.Unknown,
                StarStone = StarStone.Unknown,
                Symbol = Symbol.Unknown
            };
            AdjacentSigns = new List<SignName>();

            #region PersonalitiesAndCharacteristics

            PersonalitiesAndCharacteristics = new PersonalitiesAndCharacteristics
            {
                Career = new List<string>(),
                Cities = new List<string>(),
                Countries = new List<string>(),
                NegativeQualities = new List<string>(),
                Personality = new List<string>(),
                PositiveQualities = new List<string>(),
                Relationships = new List<string>()
            };

            #endregion
        }

        public abstract void Initialize();
    }
}