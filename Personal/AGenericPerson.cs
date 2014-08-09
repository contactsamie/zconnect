using System;
using zconnect.Astronomy;

namespace zconnect.Personal
{
    public abstract class AGenericPerson
    {
        public AstonomicalQualities AstonomicalIdentity { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string MiddleName { set; get; }

        public DateTime DateOfBirth { set; get; }
    }
}