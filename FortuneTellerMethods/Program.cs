using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerBKlein
{
    class Program
    {
         
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favColor;
            int numSibs;


            
                Console.WriteLine("Please Enter Your First Name");
                firstName = Console.ReadLine();

                Console.WriteLine("Please Enter Your Last Name");
                lastName = Console.ReadLine();

                Console.WriteLine(FullName(firstName, lastName));

                Console.WriteLine("Please Enter Your Age");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Your Birth Month in Number Form");
                birthMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Your Favorite Color from the ROYGBIV Schema in Letter Form. Enter HELP, if Needed.");
                favColor = Console.ReadLine().ToUpper();

                if (favColor == "HELP")
                {
                    Console.WriteLine("ROYGBIV is an acronym for the colors in visible light. Each letter in the acronym is the first letter of a color: R = Red; O = Orange; Y = Yellow; B = Blue; I = Indigo; and V = Violet.");
                    Console.WriteLine("Please Enter Your Favorite Color from the ROYGBIV Schema in Letter Form.");
                    favColor = Console.ReadLine().ToUpper();
                }

                Console.WriteLine("Please Enter the Number of Siblings that You Have");
                numSibs = int.Parse(Console.ReadLine());

                Console.WriteLine(firstName + " " + lastName + " will retire in " + Retire(age) + " years with $" + Money(birthMonth) + " in the bank, a vacation home in " + Vacation(numSibs) + " and a " + Transport(favColor) + ".");

                Console.WriteLine(Prognosis());
            

     
        }
        

        static string FullName(string firstName, string lastName)
        {
            return "Greetings, " + firstName + " " + lastName + ". I will tell you your fortune!";
        }

        static int Retire(int age)
        {
            int ageMod2 = age % 2;
            int retire;
            if(ageMod2 == 0)
            {
                return retire = 20;
            }
            else if(ageMod2 == 1)
            {
                return retire = 25;
            }
            else
            {
                return retire = 100;
            }
            
            
        }

        static string Vacation(int numSibs)
        {
            string vacHome;
            if (numSibs == 0)
            {
                return vacHome = "The Shire";
            }
            else if (numSibs == 1)
            {
                return vacHome = "Gondor";
            }
            else if (numSibs == 2)
            {
                return vacHome = "Rivendell";
            }
            else if (numSibs == 3)
            {
                return vacHome = "Rohan";
            }
            else if (numSibs > 3)
            {
                return vacHome = "Lothlorien";
            }
            else
            {
                return vacHome = "Mordor";
            }
        }

        static string Transport(string favColor)
        {
            string trans;
            switch (favColor)
            {
                case "R":
                    return trans = "Eagle";
                    
                case "O":
                    return trans = "Shadowfax";
                    
                case "Y":
                    return trans = "Orc";
                    
                case "G":
                    return trans = "Dragon";
                    
                case "B":
                    return trans = "Pony";
                    
                case "I":
                    return trans = "Your own two hairy hobbit feet";
                    
                case "V":
                    return trans = "Ent";
                    
                default:
                    return trans = "None";
                   
            }

        }
        static double Money(int birthMonth)
        {
            double bank;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                return bank = 10.00;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                return bank = 1000000000.00;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                return bank = 100000.00;
            }
            else
            {
                return bank = 0.00;
            }
        }

        static string Prognosis()
        {
            return "Huzzah! Lucky you!";
        }
    }
}
