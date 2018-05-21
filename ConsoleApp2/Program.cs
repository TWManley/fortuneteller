using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            string firstname = Console.ReadLine().ToLower();
            Console.WriteLine("What is your last name");
            string lastname = Console.ReadLine().ToLower();
            Console.WriteLine("What is your age");
            int age = int.Parse(Console.ReadLine());
            if (age % 2 == 0) { Console.WriteLine("you will retire in 10 years"); }
            else { Console.WriteLine(" you will retire in 45 years"); }
            Console.WriteLine("What is your birth month");
            int birthmonth = int.Parse(Console.ReadLine());
            if (birthmonth == 1) { Console.WriteLine("you will have 10 dollars!"); }
            else if (birthmonth == 0) { Console.WriteLine("you will have 0 dollars in the bank"); }
            else if (birthmonth == 2) { Console.WriteLine("you will have 10 dollars!"); }
            else if (birthmonth == 3) { Console.WriteLine("you will have 10 dollars!"); }
            else if (birthmonth == 4) { Console.WriteLine("you will have 10 dollars!"); }
            else if (birthmonth == 5) { Console.WriteLine("you will have 100 dollars!"); }
            else if (birthmonth == 6) { Console.WriteLine("you will have 100 dollars!"); }
            else if (birthmonth == 7) { Console.WriteLine("you will have 100 dollars!"); }
            else if (birthmonth == 8) { Console.WriteLine("you will have 100 dollars!"); }
            else if (birthmonth == 9) { Console.WriteLine("you will have 1000 dollars!"); }
            else if (birthmonth == 10) { Console.WriteLine("you will have 1000 dollars!"); }
            else if (birthmonth == 11) { Console.WriteLine("you will have 1000 dollars!"); }
            else if (birthmonth == 12) { Console.WriteLine("you will have 1000 dollars!"); }
            else if (birthmonth > 12) { Console.WriteLine("you will have 0.00 dollars!"); }
            Console.WriteLine("What is your favorite ROYGBIV color, enter help if you do not understand?");
            string favoritecolor = (Console.ReadLine());
            if (favoritecolor == "help")
            { Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet."); }
            if (favoritecolor == "Red") { Console.WriteLine("you will have a bicycle"); }
            else if (favoritecolor == "Orange") { Console.WriteLine("you will drive a car"); }
            else if (favoritecolor == "Yellow") { Console.WriteLine("you will ride roller skate"); }
            else if (favoritecolor == "Green") { Console.WriteLine("You will ride the bus"); }
            else if (favoritecolor == "Blue") { Console.WriteLine("your gonna walk til you drop"); }
            else if (favoritecolor == "Indigo") { Console.WriteLine("you will drive a 2018 Dodge Challenger SRT HellCat"); }
            else if (favoritecolor == "Violet") { Console.WriteLine("your primary mode of transport is unicycle"); }
            Console.WriteLine("how many siblings do you have?");
            int numberofsiblings = int.Parse(Console.ReadLine());
            if (numberofsiblings == 0) { Console.WriteLine("You will retire at Shady Pines retirement village"); }
            else if (numberofsiblings == 1) { Console.WriteLine("you will retire to the forest!"); }
            else if (numberofsiblings == 2) { Console.WriteLine("you will retire to Kennybunport Maine!"); }
            else if (numberofsiblings == 3) { Console.WriteLine("you will retire to a government funded care facility!"); }
            Console.WriteLine("{0} {1}" + " you will retire in {2} years " +
                "with {3} dollars in the bank "+ "and a vacation home in {4}"+ "your mode of trtiansport will be{5}", firstname,lastname,age, birthmonth,numberofsiblings,favoritecolor);

               
             
            






            








        }
    }
}
