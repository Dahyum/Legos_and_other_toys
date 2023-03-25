using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lego_and_other_toys_Project.Input
{
    public class Menu
    {

        public  static void BaseMenu()
        {
            Console.WriteLine("          " + "WELCOME TO THE TOY SHOP!" );
            Console.WriteLine();
            Console.WriteLine("          " + "   How can we help you?");
            Console.WriteLine();
            Console.WriteLine("Would you like to look for :");
            Console.WriteLine("1 - LEGO sets?");
            Console.WriteLine("2 - OTHER toys?");


        }

        public static void OtherMenu()
        {
            Console.WriteLine("          " + "ALRIGHT!");
            Console.WriteLine();
            Console.WriteLine(" " + "What would you like to look for?");
            Console.WriteLine();
            Console.WriteLine("1 - SPORT TOYS?");
            Console.WriteLine("2 - BABY toys?");
            Console.WriteLine("3 - BOARD games?");
            Console.WriteLine("4 - EXIT?");


        }

        public static void LegoMenu()
        {
            Console.WriteLine("          " + "AWESOME CHOICE!");
            Console.WriteLine();
            Console.WriteLine("   " + "WHAT WOULD YOU LIKE TO SEARCH BY?");
            Console.WriteLine();
            Console.WriteLine("1 - Search by NAME\n" +
                "2 - Search by PRICE\n3 - Search by RATING\n");
        }

        public static void SportMenu()
        {
            Console.WriteLine("          " + "GOOD CHOICE!");
            Console.WriteLine();
            Console.WriteLine(" " + "WHAT WOULD YOU LIKE TO SEARCH BY?");
            Console.WriteLine();
            Console.WriteLine("1 - Search by SPORT\n2 - Search by PRICE");
        }

        public static void BabyToyMenu()
        {
            Console.WriteLine("          " + "GOOD CHOICE!");
            Console.WriteLine();
            Console.WriteLine(" " + "WHAT WOULD YOU LIKE TO SEARCH BY?");
            Console.WriteLine();
            Console.WriteLine("1 - Search by AGE\n2 - Search by SIZE");
        }

        public static void BoardGameMenu()
        {
            Console.WriteLine("          " + "GOOD CHOICE!");
            Console.WriteLine();
            Console.WriteLine(" " + "WHAT WOULD YOU LIKE TO SEARCH BY?");
            Console.WriteLine();
            Console.WriteLine("1 - Search by AGE\n2 - Search by NUMBER OF PLAYERS");
        }

        public static void More()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("       WOULD YOU LIKE TO BROWSE MORE?");
        }

    }
}
