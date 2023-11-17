using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ABB aBB = new ABB();

            aBB.insert(10);
            aBB.insert(5);
            aBB.insert(23);
            aBB.insert(1);
            aBB.insert(40);

            //aBB.ShowTree(aBB.);
        }
    }
}
