using System;
using System.Globalization;
using System.Transactions;
using Lego_and_other_toys_Project.Controllers;
using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using Lego_and_other_toys_Project.Input;
using Microsoft.Extensions.Caching.Memory;

namespace Lego_and_other_toys_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu.BaseMenu();
            int n = int.Parse(Console.ReadLine());
            while (n != 4)
            {


                switch (n)
                {
                    case 1:
                        Menu.LegoMenu();
                        int l = int.Parse(Console.ReadLine());
                        switch (l)
                        {
                            case 1:
                                string legoname = Console.ReadLine();
                                LegoController lgn = new LegoController();
                                lgn.SearchByName(legoname);
                                Menu.More();
                                string more1 = Console.ReadLine();
                                if (more1 == "no")
                                {
                                    break;
                                }
                                break;
                            case 2:
                                decimal legoprice = decimal.Parse(Console.ReadLine());
                                LegoController lgp = new LegoController();
                                lgp.SearchByPrice(legoprice);
                                Menu.More();
                                more1 = Console.ReadLine();
                                if (more1 == "no")
                                {
                                    break;
                                }
                                break;
                            case 3:
                                string legorating = Console.ReadLine();
                                LegoController lgr = new LegoController();
                                lgr.SearchByRating(legorating);
                                Menu.More();
                                more1 = Console.ReadLine();
                                if (more1 == "no")
                                {
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid");
                                Menu.More();
                                more1 = Console.ReadLine();
                                if (more1 == "no")
                                {
                                    break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        Menu.OtherMenu();
                        int o = int.Parse(Console.ReadLine());
                        switch (o)
                        {
                            case 1:
                                Menu.SportMenu();
                                int s = int.Parse(Console.ReadLine());
                                switch (s)
                                {
                                    case 1:
                                        string sport = Console.ReadLine();
                                        SportsToysController spts = new SportsToysController();
                                        spts.SearchBySport(sport);
                                        Menu.More();
                                        string more2 = Console.ReadLine();
                                        if (more2 == "no")
                                        {
                                            break;
                                        }
                                        break;
                                    case 2:
                                        decimal price = decimal.Parse(Console.ReadLine());
                                        SportsToysController sptp = new SportsToysController();
                                        sptp.SearchByPrice(price);
                                        Menu.More();
                                        more2 = Console.ReadLine();
                                        if (more2 == "no")
                                        {
                                            break;
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("Invalid");
                                        Menu.More();
                                        more2 = Console.ReadLine();
                                        if (more2 == "no")
                                        {
                                            break;
                                        }
                                        break;
                                }

                                    ; break;
                            case 2:
                                Menu.BabyToyMenu();
                                int bb = int.Parse(Console.ReadLine());
                                switch (bb)
                                {
                                    case 1:
                                        int bbtage = int.Parse(Console.ReadLine());
                                        BabyToyController bbtca = new BabyToyController();
                                        bbtca.SearchByAge(bbtage);
                                        Menu.More();
                                        string more3 = Console.ReadLine();
                                        if (more3 == "no")
                                        {
                                            break;
                                        }
                                        break;
                                    case 2:
                                        string bbtsize = Console.ReadLine();
                                        BabyToyController bbtcs = new BabyToyController();
                                        bbtcs.SearchBysize(bbtsize);
                                        Menu.More();
                                        more3 = Console.ReadLine();
                                        if (more3 == "no")
                                        {
                                            break;
                                        }

                                        break;
                                    default:
                                        Console.WriteLine("invalid");
                                        Menu.More();
                                        more3 = Console.ReadLine();
                                        if (more3 == "no")
                                        {
                                            break;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                Menu.BoardGameMenu();
                                int bg = int.Parse(Console.ReadLine());
                                switch (bg)
                                {
                                    case 1:
                                        int bgage = int.Parse(Console.ReadLine());
                                        BoardGameController bgcp = new BoardGameController();
                                        bgcp.SearchByAge(bgage);
                                        Menu.More();
                                        string more4 = Console.ReadLine();
                                        if (more4 == "no")
                                        {
                                            break;
                                        }
                                        break;
                                    case 2:
                                        int bgnop = int.Parse(Console.ReadLine());
                                        BoardGameController bgcnop = new BoardGameController();
                                        bgcnop.SearchByNoP(bgnop);
                                        Menu.More();
                                        more4 = Console.ReadLine();
                                        if (more4 == "no")
                                        {
                                            break;
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                break;
                            default:
                                Console.WriteLine("Invalid");
                                Menu.More();
                                string more5 = Console.ReadLine();
                                if (more5 == "no")
                                {
                                    break;
                                }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        Menu.More();
                        string more = Console.ReadLine();
                        if (more == "no")
                        {
                            break;
                        }
                        break;
                }

            }

        }


        public static void AddSportToy()
        {
            SportsToysController sptc = new SportsToysController();
            SportToy sportToy = new SportToy();
            Console.WriteLine("Enter toy name:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            Console.WriteLine("Enter toy sport:");
            string sport = Console.ReadLine();
            if (string.IsNullOrEmpty(sport))
            {
                Console.WriteLine("Sport cannot be empty!");
                return;
            }
            Console.WriteLine("Enter toy price:");
            decimal price = decimal.Parse(Console.ReadLine());

            if (price <= 0)
            {
                Console.WriteLine("Price cannot be 0 or negative!");
                return;

            }
            sportToy.ToyName = name;
            sportToy.Sport = sport;
            sportToy.Price = price;
            sptc.AddSportToy(sportToy);
        }

        public static void AddBoardGame()
            {
            BoardGameController bgc = new BoardGameController();
            BoardGame boardGame = new BoardGame();
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            Console.WriteLine("Enter game:");
            int nop = int.Parse(Console.ReadLine());
            if (nop <= 0)
            {
                Console.WriteLine("Number of players cannot be 0 or negative!");
                return;
            }

            Console.WriteLine("Enter board age:");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative!");

            }
            Console.WriteLine("Enter toy price:");
            decimal price = decimal.Parse(Console.ReadLine());

            if (price <= 0)
            {
                Console.WriteLine("Price cannot be 0 or negative!");
                return;

            }

        }
        public void DeleteSPortToy()
        {
            SportsToysController sport = new SportsToysController();

            Console.WriteLine("Enter the name of the toy you want to delete: ");
            string name = Console.ReadLine();
           
            sport.DeleteSportToyByName(name);
        }

        public static void DeleteBoardGame()
        {
            BoardGameController bgc = new BoardGameController();
            Console.WriteLine("Enter the name of the game you want to delete: ");
            string name = Console.ReadLine();

            bgc.DeleteBoardGameByName(name);
        }

        public void EditSportToy()
        {
            SportsToysController sptc = new SportsToysController();
            Console.WriteLine("Enter the name of the toy you want to edit: ");
            string name = Console.ReadLine();

            SportToy sportToy = sptc.GetSportToyByName(name);
            Console.WriteLine("Enter new name:");
            string newname = Console.ReadLine();
            Console.WriteLine("Enter new price:");
            decimal newprice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter new sport");
            string newsport = Console.ReadLine();

            sptc.EditSportToy(sportToy, newname, newsport, newprice);
           
        }

        public void EditBoardGame()
        {
            BoardGameController bgc = new BoardGameController();
            Console.WriteLine("Enter the name of the board game you want to edit: ");
            string name = Console.ReadLine();

            BoardGame boardgame = bgc.GetBoardGameByName(name);
            Console.WriteLine("Enter new name: ");
            string newname = Console.ReadLine();

            Console.WriteLine("Enter new price:");
           int newprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new NoP: ");
            int newnop = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new age: ");
            int newage = int.Parse(Console.ReadLine());

            bgc.EditBoardGame(boardgame, newname, newprice, newnop, newage);
        }

    }
}
