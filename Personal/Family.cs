using System.Collections.Generic;

namespace zconnect.Personal
{
    public class Family
    {
        public List<AGenericPerson> Siblings { set; get; }
        public AGenericPerson Father { set; get; }
        public AGenericPerson Mother { set; get; }
        public AGenericPerson Partner { set; get; }
    }
}