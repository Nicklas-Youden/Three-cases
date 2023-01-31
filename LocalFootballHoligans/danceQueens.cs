using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarys;

namespace Consoleapps

{
    internal class DanceQueens:DanseQueenLibrarys
    {
        public void DanceQueen()
        {
            Console.WriteLine("Name:");
            //Type the name of the first judge
            string Name = Console.ReadLine();
            Console.WriteLine("gives:");
            // the score of the first judge
            int Points = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Name:");
            //Type the name of the secound judge
            string Name1 = Console.ReadLine();
            Console.WriteLine("Gives:");
            //Type what the secound judge gives
            int Points1 = Convert.ToInt32(Console.ReadLine());

            var score = new DanseQueenLibrarys();
            //the outcome of the score
            string score1 = score.DanseQueens(Points, Points1);

            Console.WriteLine(Name + " & " + Name1 + " " + score1);
            Console.Clear();
            Console.ReadKey();


        }
    }
}
