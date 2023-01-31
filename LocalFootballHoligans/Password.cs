using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarys;
using System.IO;

namespace Consoleapps
{
    internal class Password:PasswordLibarys
    {

        public void Passwords()
        {


            string[] login= new string[0];
            string path = @"..\login\login.txt";
                bool breakloop = false;
            //If the Login file is not there then create one and make a password
            if (!File.Exists(path))
            {
                do
                {
                    //Type the new username of the user
                    Console.WriteLine("Wirte a new Username");
                    string username = Console.ReadLine();
                    //Type the password --||--
                    Console.WriteLine("Wirte a new Password");
                    string password = Console.ReadLine();

                    var respond = new PasswordLibarys();
                    //Is the password legal? yes no
                    bool respund1 = respond.Passwordslib(username, password);

                    if (respund1 == false)
                    {
                        //no its not legal
                        Console.WriteLine("Your password is not allowed");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    { //Yes its legal
                        breakloop = true;
                        Console.WriteLine("Login successful");
                        Console.ReadKey();
                        Console.Clear();
                        login = login.Append(username).ToArray();
                        login = login.Append(password).ToArray();
                        File.AppendAllLines(path, login);

                    }
                } while (breakloop == false);
            }
            else { 
                //If the login file is there!
                login = File.ReadAllLines(path);
                while (breakloop== false)
                {
                    string password = "";
                    //Type username and password of the user
                    Console.WriteLine("Wirte your Username");
                    string username = Console.ReadLine();
                    if (username == login[0])
                    {
                        Console.WriteLine("Wirte your password");
                        password = Console.ReadLine();
                        if (password == login[1])
                        {
                            //password is okay so lets break the loop
                            breakloop= true;
                        }
                    } 
                    if (username != login[0]|| password != login[1])
                    {//Your user or password is worng
                        Console.Clear();
                        Console.WriteLine("Your username or password is worng");
                    }
                }
                
            Console.WriteLine("Do you want to change your password? \n Y= Yes N= No");
                //Ask to change the password this should only happen if you have a user in the first place
            string yesno= Console.ReadLine();
            yesno = yesno.ToUpper();
            if (yesno == "Y")
            {

                bool respond1;

                do
                {

                    //change password

                    Console.WriteLine("Wirte your Username");
                    string username = Console.ReadLine();

                    Console.WriteLine("Wirte your new password");
                    string password = Console.ReadLine();
                        //Password check if its legal
                    var respond = new PasswordLibarys();
                    respond1 = respond.Passwordslib(username, password);

                    if (username == login[0] || password == login[1])
                    {
                            //If you type the same password as last time
                        Console.Clear();
                        respond1 = false;
                        Console.WriteLine("Your username or password is the same as last time");

                    }
                    else if (respond1 == true)
                    {

                            //You have a legal password and its not the same as the lsast
                        respond1 = true;
                        login = new string[0].Append(username).ToArray();
                        login = login.Append(password).ToArray();
                        File.Delete(path);
                        File.AppendAllLines(path, login);

                    }
                } while (respond1 == false);
            }



            else if (yesno == "N")
            {// In case you dont want to change the password anything else would also mean a no
                Console.WriteLine("Okay maybe another time then");
            }
            }
        }
            


    }
}

