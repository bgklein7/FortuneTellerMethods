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

            int ageMod2 = age % 2;
            string retire;
            switch (ageMod2)
            {
                case 0:
                    retire = "20 years";
                    break;

                case 1:
                    retire = "25 years";
                    break;

                default:
                    retire = "100 years";
                    break;
            }

            string vacHome;
            if (numSibs == 0)
            {
                vacHome = "The Shire";
            }
            else if (numSibs == 1)
            {
                vacHome = "Gondor";
            }
            else if (numSibs == 2)
            {
                vacHome = "Rivendell";
            }
            else if (numSibs == 3)
            {
                vacHome = "Rohan";
            }
            else if (numSibs > 3)
            {
                vacHome = "Lothlorien";
            }
            else
            {
                vacHome = "Mordor";
            }

            string trans;
            switch (favColor)
            {
                case "R":
                    trans = "Eagle";
                    break;

                case "O":
                    trans = "Shadowfax";
                    break;

                case "Y":
                    trans = "Orc";
                    break;

                case "G":
                    trans = "Dragon";
                    break;

                case "B":
                    trans = "Pony";
                    break;

                case "I":
                    trans = "Your own two hairy hobbit feet";
                    break;

                case "V":
                    trans = "Ent";
                    break;

                default:
                    trans = "None";
                    break;
            }

            string bank;
            if(birthMonth >= 1 && birthMonth <= 4)
            {
                bank = "$10.00";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bank = "$1,0000,000,000.00";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bank = "$100,000.00";
            }
            else
            {
                bank = "$0.00";
            }
           
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + " with " + bank + " in the bank, a vacation home in " + vacHome + " and a " + trans + ".");

        }
    }
}
