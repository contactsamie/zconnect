using System.Collections.Generic;

namespace zconnect
{
    public abstract class APerson : APersonWithoutAFamily
    {
        /// <summary>
        /// the goal is to derive conclusions based on a person's data
        /// </summary>
        public List<string> Conclusions { set; get; }

        public string CityOfBirth { set; get; }

        public string CountryOfBirth { set; get; }

        public Family Family { set; get; }
    }
}