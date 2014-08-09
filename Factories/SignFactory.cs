using System;
using System.Collections.Generic;
using zconnect.Astronomy;
using zconnect.Components;
using zconnect.Concrete;
using zconnect.Concrete.Signs;
using zconnect.Models;
using zconnect.SignProperties;

namespace zconnect.Factories
{
    public class SignFactory
    {
        public static BaseSign GetSignByName(SignName name)
        {
            BaseSign sign;
            switch (name)
            {
                case SignName.Aquarius:
                    sign = new Aquarius
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.Air,
                        OppositeSign = SignName.Leo,
                        Rulers = new List<Ruler>()
                        {
                            Ruler.Saturn,
                            Ruler.Uranus
                        },
                        QualityGroup = QualityGroup.Fixed,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>()
                            {
                                BodyPart.Ankles,
                                BodyPart.CirculatorySystem
                            },
                            Color = Color.Skyblue,
                            DayOfWeek = SignDayOfWeek.Saturday,
                            Gemstones = new List<Gemstone>()
                            {
                                Gemstone. Amethyst,
                                Gemstone.Aquamarine
                            },
                            Metal = Metal.Uranium,
                            Season = Season.Winter,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.TheWaterCarrier
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Taurus:
                    sign = new Taurus
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.April, 20, MonthName.May, 20),
                        Element = Element.Earth,
                        OppositeSign = SignName.Scorpio,
                         Rulers = new List<Ruler>()
                         {
                             Ruler.Venus
                         },
                        QualityGroup = QualityGroup.Fixed,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Scorpio:
                    sign = new Scorpio
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Sagittarius:
                    sign = new Sagittarius
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Pisces:
                    sign = new Pisces
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Libra:

                    sign = new Libra
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Leo:
                    sign = new Leo
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Gemini:
                    sign = new Gemini
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Capricorn:
                    sign = new Capricorn
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Cancer:
                    sign = new Cancer
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Aries:
                    sign = new Aries
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Virgo:
                    sign = new Virgo
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                case SignName.Unknown:
                    sign = new UnknownSign
                    {
                        #region Sign Definition

                        Name = name,
                        Definition = new Definition(MonthName.January, 20, MonthName.February, 18),
                        Element = Element.UnknownElement,
                        OppositeSign = SignName.Unknown,
                         Rulers = new List<Ruler>(){},
                        QualityGroup = QualityGroup.UnknownQualityGroup,
                        OtherRepresentation = new OtherRepresentation
                        {
                            Animal = Animal.Unknown,
                            BodyParts = new List<BodyPart>(){},
                            Color = Color.Unknown,
                            DayOfWeek = SignDayOfWeek.Unknown,
                            Gemstones = new List<Gemstone>(){} ,
                            Metal = Metal.Unknown,
                            Season = Season.Unknown,
                            StarStone = StarStone.Unknown,
                            Symbol = Symbol.Unknown
                        },
                        AdjacentSigns = new List<SignName>()

                        #endregion Sign Definition
                    };
                    break;

                default:
                    throw new NotImplementedException();
            }
            sign.Initialize();
            return sign;
        }
    }
}