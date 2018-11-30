using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Disk
    {
        public string name;
        public double price;
        public string author;
        public string genre;

        public Disk(string N, double P, string A, string G)
        {
            name = N;
            price = P;
            author = A;
            genre = G;
        }
    }
}
