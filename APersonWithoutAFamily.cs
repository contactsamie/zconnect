using System;

namespace zconnect
{
    public abstract class APersonWithoutAFamily
    {
        public AstonomicalQualities AstonomicalIdentity { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string MiddleName { set; get; }

        public DateTime DateOfBirth { set; get; }
    }
}