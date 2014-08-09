using System.Collections.Generic;

namespace zconnect.Personal
{
    public abstract class APerson : AGenericPerson
    {
        /// <summary>
        ///     the goal is to derive conclusions based on a person's data
        /// </summary>
        public List<string> Conclusions { set; get; }

        public string CityOfBirth { set; get; }

        public string CountryOfBirth { set; get; }

        public Family Family { set; get; }
    }
}