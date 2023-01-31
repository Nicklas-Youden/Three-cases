using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarys;

namespace Consoleapps
{
    internal class LocalFootballHoligans:LocalFootballHoligansLibrarys
    {
        public
            void Footbal()
        {
            Console.WriteLine("Passes");
            //How many passes
            int pass = Convert.ToInt32(Console.ReadLine());
            //if the ball came into the net
            string mål = Console.ReadLine();
           // a new string thats also the respond from the lib
            var jubel = new LocalFootballHoligansLibrarys();
           //The output
            Console.WriteLine(jubel.Football(pass, mål));
            Console.ReadKey();

            
        }
    }
}
