using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Consoleapps
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			
			
			string choice;
			//A do while loop so the console just dont desapiear
			do {
				Console.WriteLine("Type 1 for football 2 for dance 3 for password or Q for quit");
				choice = Console.ReadLine();
				choice = choice.ToUpper();
				//Depends on what you type on the line above determents on whare you will go
				if (choice == "1")
				{//if type 1 then it will go to football
					var GoToFootball = new LocalFootballHoligans();
					GoToFootball.Footbal();
				} else if (choice == "2")
				{//2 will go to dance
					var GoToDance = new DanceQueens();
					GoToDance.DanceQueen();
				} else if (choice == "3")
				{// 3 will go to the password section
					var GoToPassword = new Password();
					GoToPassword.Passwords();
				}

				//Just a failsafe if you type something else
				else { Console.WriteLine("You have fail to enter 1, 2, 3 or Q");
					Console.ReadKey();
					Console.Clear();
				} //To quit the console
			} while (choice != "Q");



			
		}
	}
}
