using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinPipeline_ConsolApp2
{
    internal class Program
    {
        void show()
        {
            int a = 5, b;
            b = a * a;
            Console.WriteLine("Square of a="+b);

        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.show();
            Console.ReadLine();
        }
    }
}
