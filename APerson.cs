using System;

namespace zconnect
{
    public abstract class APerson
    {
        public ASign Sign { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string CityOfBirth { set; get; }
        public string CountryOfBirth { set; get; }
    }
}