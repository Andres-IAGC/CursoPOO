using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Figura
    {
        public int Rx, Ry;
        public Figura(int Rx, int Ry)
       {
            this.Rx = Rx;
            this.Ry = Ry;
    
       }
    }
   

    class Program
    {
        static void Main(string[] args)
        {

            for(int i; i< 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
