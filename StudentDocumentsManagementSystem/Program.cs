using System;
using System.Collections.Generic;

namespace StudentDocumentsManagementSystem
{
    class Program
    {

        

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to SDMS!");

            Console.Write("Username: ");
            string UsrName = Console.ReadLine();
            Console.Write("Password: ");
            string PsWord = Console.ReadLine();
           


            if (UsrName == "admin" & PsWord == "admin")
            {

                Console.WriteLine("||||You are logged in!||||");
                Console.Clear();


                for (var userInput = UserInputValue();
                              userInput != actions.IndexOf('X');
                              userInput = UserInputValue())
                {

                    if (userInput.Equals(actions.IndexOf('A')))
                    {
                        string studname1 = ("Murro, Bryll Kenryl T.");
                        string studname2 = ("Alejandre, Adrian S.");
                        Console.WriteLine("\n");

                        Console.WriteLine("Enter Student Name: ");
                        string studname = Console.ReadLine();
                        Console.Clear();

                        if (studname == (studname1))
                        {
                            Console.WriteLine("Documents completed!");
                            Console.WriteLine("\n");
                           
                        }
                        else if (studname == (studname2))
                        {
                            Console.WriteLine("Documents incomplete!");
                           
                        }
                        else
                            Console.WriteLine("Invalid!");
                        

                    }
                    else if (userInput.Equals(actions.IndexOf('B')))
                    {

                    }
                    else if (userInput.Equals(actions.IndexOf('C')))
                    {

                    }


                }
                Console.WriteLine("Exiting.");
            }
            else
            {
                Console.WriteLine("ERROR!!!!!");
            }
        }





        public static List<string> logs = new List<string>();
        public static List<string> actionsDescription = new List<string>()
                        { "'A' Admission Requirements","'B' Clearance","'C' Transcript of Record","'X' EXIT"};
        public static List<char> actions = new List<char>() { 'A', 'B', 'C', 'X' };
        static void ShowUserOptions()
        {

            foreach (var decription in actionsDescription)
            {
                Console.WriteLine(decription);
            }
        }

        static int UserInputValue()
        {
            ShowUserOptions();
            
            Console.Write("Enter Here: ");
            var action = (Convert.ToChar(Console.ReadLine().ToUpper()));
            var actionIndex = actions.IndexOf(action);
            Console.Clear();

            if (actionIndex != -1)
            {

                return actionIndex;
            }
            else
            {
                var message = "INVALID INPUT! Please try again.......";
                Console.WriteLine(message);
                Console.Clear();

                return UserInputValue();
            }
        }



    }

   }




         

