using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Supply
    {
        public string disc;
        public string client;
        public string seller;

        public Supply(string D, string C, string S)
        {
            disc = D;
            client = C;
            seller = S;
        }
    }
}
