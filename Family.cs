using System.Collections.Generic;

namespace zconnect
{
    public class Family
    {
        public List<APersonWithoutAFamily> Siblings { set; get; }
        public APersonWithoutAFamily Father { set; get; }
        public APersonWithoutAFamily Mother { set; get; }
        public APersonWithoutAFamily Partner { set; get; }
    }
}