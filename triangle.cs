using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    internal class triangle
    {

    }

    struct Coordinenatr
    {
        public int en;
        public int uzunlug1;
        public int uzunlug2;
        public int pemetr()
        {
            return (uzunlug1 + uzunlug2 + en);
        }

        public Coordinenatr (int en, int uzunlug1, int uzunlug2)
        {
            this.en = en;
            this.uzunlug1 = uzunlug1;
            this.uzunlug2 = uzunlug2;
            

        }
    }
}
