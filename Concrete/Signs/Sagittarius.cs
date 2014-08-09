using System.Collections.Generic;
using zconnect.Astronomy;
using zconnect.Components;

namespace zconnect.Concrete.Signs
{
    public class Sagittarius : BaseSign
    {
        public override void Initialize()
        {
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

            #endregion PersonalitiesAndCharacteristics
        }
    }
}