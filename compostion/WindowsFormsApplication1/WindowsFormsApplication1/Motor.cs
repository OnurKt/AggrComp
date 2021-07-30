using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Motor
    {
        int mgucu, tork, beygir;

        public int Beygir
        {
            get { return beygir; }
            set { beygir = value; }
        }

        public int Tork
        {
            get { return tork; }
            set { tork = value; }
        }

        public int Mgucu
        {
            get { return mgucu; }
            set { mgucu = value; }
        }
    }
}
