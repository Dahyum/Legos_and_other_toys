using System;
using System.Globalization;
using System.Transactions;
using System.Windows.Markup;
using Lego_and_other_toys_Project.Controllers;
using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using Lego_and_other_toys_Project.Input;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;

namespace Lego_and_other_toys_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int closeOperationId = 26;
            Mainmenu();
            var operation = 0;
            do
            {
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AddLegoSet();
                        break;
                    case 2:
                        DeleteLegoSetByName();
                        break;
                    case 3:
                        EditLegoSetByName();
                        break;
                    case 4:
                        AddSportToy();
                        break;
                    case 5:
                        DeleteSportToy();
                        break;
                    case 6:
                        EditSportToy();
                        break;
                    case 7:
                        AddBabyToy();
                        break;
                    case 8:
                        DeleteBabyToy();
                        break;
                    case 9:
                        EditBabyToy();
                        break;
                    case 10:
                        AddBoardGame();
                        break;
                    case 11:
                        DeleteBoardGame();
                        break;
                    case 12:
                        EditBoardGame();
                        break;
                    case 13:
                        SearchLegoByName();
                        break;
                    case 14:
                        SearchLegoByPrice();
                        break;
                    case 15:
                        SearchLegoByRating();
                        break;
                    case 16:
                        SearchSportToyBySport();
                        break;
                    case 17:
                        SearchSportToyByPrice();
                        break;
                    case 18:
                        SearchBabyToyByAge();
                        break;
                    case 19:
                        SearchBabyToyToyBySize();
                        break;
                    case 20:
                        SearchBoardGameByAge();
                        break;
                    case 21:
                        SearchBoardGameByNoP();
                        break;
                    case 22:
                        ListAllLegoSets();
                        break;
                    case 23:
                        ListAllBoardgames();
                        break;
                    case 24:
                        ListAllBabyToys();
                        break;
                    case 25:
                        ListAllSportToys();
                        break;
                    default:
                        break;
                }
                
            } while (operation != closeOperationId);

        }
        public static void Mainmenu()
        {
            Console.WriteLine("1. AddLegoSet");
            Console.WriteLine("2. Remove lego set");
            Console.WriteLine("3. Edit lego set");
            Console.WriteLine("-----------------------");
            Console.WriteLine("4. Add sport toy");
            Console.WriteLine("5. Delete sport toy");
            Console.WriteLine("6. Edit sprot toy");
            Console.WriteLine("-----------------------");
            Console.WriteLine("7. Add babay toy");
            Console.WriteLine("8. Delete baby toy");
            Console.WriteLine("9. Edit baby toy");
            Console.WriteLine("-----------------------");
            Console.WriteLine("10. Add board game");
            Console.WriteLine("11. Delete board game");
            Console.WriteLine("12. Edit board game");
            Console.WriteLine("-----------------------");
            Console.WriteLine("13. Search lego by name");
            Console.WriteLine("14. Search lego by price");
            Console.WriteLine("15. Search lego by rating");
            Console.WriteLine("------------------------");
            Console.WriteLine("16. Search sporttoy by sport");
            Console.WriteLine("17. Search sport toy by price");
            Console.WriteLine("------------------------------");
            Console.WriteLine("18. Search baby toy by age");
            Console.WriteLine("19. Search baby toy by size");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("20. Search board game by age");
            Console.WriteLine("21. Search board game by number of players");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("22. Show all Legos");
            Console.WriteLine("23. Show all Board Games");
            Console.WriteLine("24. Show all BabyToys");
            Console.WriteLine("25. Show all SportToys");
            Console.WriteLine("26. Exit");
        }

        // sport toy operations
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
        public static void DeleteSportToy()
        {
            SportsToysController sport = new SportsToysController();

            Console.WriteLine("Enter the name of the toy you want to delete: ");
            string name = Console.ReadLine();

            sport.DeleteSportToyByName(name);
        }

        public static void EditSportToy()
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

        public static void SearchSportToyBySport()
        {
            SportsToysController spt = new SportsToysController();
            string sport = Console.ReadLine();
            spt.SearchBySport(sport);
        }

        public static void SearchSportToyByPrice()
        {
            SportsToysController spt = new SportsToysController();
            int price = int.Parse(Console.ReadLine());
            spt.SearchByPrice(price);
        }

        //lego set operations
        public static void AddLegoSet()
        {
            LegoController lc = new LegoController();
            LegoSet legoSet = new LegoSet();
            Console.WriteLine("Enter legoset name:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            Console.WriteLine("Enter series name:");
            string series = Console.ReadLine();
            if (string.IsNullOrEmpty(series))
            {
                Console.WriteLine("series name cannot be empty!");
                return;
            }
            Console.WriteLine("Is in stock?");
            bool inStock = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter age group:");
            int ageGr = int.Parse(Console.ReadLine());
            if (ageGr < 0)
            {
                Console.WriteLine("Cannot be less than 0!");
                return;
            }
            Console.WriteLine("Enter nop");
            int nop = int.Parse(Console.ReadLine());
            if (nop < 0)
            {
                Console.WriteLine("Cannot be less than 0");
                return;
            }
            Console.WriteLine("Enter price");
            decimal price = decimal.Parse(Console.ReadLine());
            if (price < 0)
            {
                Console.WriteLine("Cannot be less than 0!");
                return;
            }
            Console.WriteLine("enter rating");
            string rating = Console.ReadLine();
            Console.WriteLine("Is in production?");
            bool inProduction = bool.Parse(Console.ReadLine());
            legoSet.Set_name = name;
            legoSet.Series_name = series;
            legoSet.In_stock = inStock;
            legoSet.Age_group = ageGr;
            legoSet.NoB = nop;
            legoSet.Price = price;
            legoSet.Rating = rating;
            legoSet.In_Production = inProduction;
            lc.AddLegoSet(legoSet);
        }
        public static void DeleteLegoSetByName()
        {
            LegoController lc = new LegoController();

            Console.WriteLine("Enter the name of the legoset you want to delete: ");
            string name = Console.ReadLine();

            lc.DeleteLegoSetByName(name);
        }

        public static void EditLegoSetByName()
        {
            LegoController lc = new LegoController();
            Console.WriteLine("Enter the name of the legoset you want to edit: ");
            string name = Console.ReadLine();

            LegoSet legoset = lc.GetLegoSetByName(name);
            Console.WriteLine("Enter new name:");
            string newname = Console.ReadLine();
            Console.WriteLine("Enter new series name:");
            string seriesname = Console.ReadLine();
            Console.WriteLine("InStock?");
            bool inStock = bool.Parse(Console.ReadLine());
            Console.WriteLine("Age group");
            int agegr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter nop");
            int nop = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter rating");
            string rating = Console.ReadLine();
            Console.WriteLine("inProduction?");
            bool inPr = bool.Parse(Console.ReadLine());

            lc.EditLegoSet(legoset, newname, seriesname, inStock, agegr, nop, price, rating, inPr);

        }
        public static void SearchLegoByName()
        {
            LegoController lc = new LegoController();
            string name = Console.ReadLine();
            lc.SearchByName(name);

        }

        public static void SearchLegoByPrice()
        {
            LegoController lc = new LegoController();
            decimal price = decimal.Parse(Console.ReadLine());
            lc.SearchByPrice(price);
        }

        public static void SearchLegoByRating()
        {
            LegoController lc = new LegoController();
            string rating = Console.ReadLine();
            lc.SearchByRating(rating);
        }

        //baby toy operatins

        public static void AddBabyToy()
        {
            BabyToyController btc = new BabyToyController();
            BabyToy babyToy = new BabyToy();
            Console.WriteLine("Enter toy name:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            Console.WriteLine("Enter toy size:");
            string size = Console.ReadLine();
            if (string.IsNullOrEmpty(size))
            {
                Console.WriteLine("Sport cannot be empty!");
                return;
            }
            Console.WriteLine("Enter toy price:");
            decimal price = decimal.Parse(Console.ReadLine()); if (price <= 0)
            {
                Console.WriteLine("Price cannot be 0 or negative!");
                return;
            }
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine()); if (age < 0)
            {
                Console.WriteLine("Age cannot be negative!");
                return;
            }
            babyToy.Toy_name = name;
            babyToy.Age = age;
            babyToy.Size = size;
            babyToy.Price = price;
            btc.AddBabyToy(babyToy);
        }

        public static void ListAllBabyToys()
        {
            BabyToyController bbc = new BabyToyController();
            var babytoys = bbc.GetAllBabyToys();
            foreach (var item in babytoys)
            {
                Console.WriteLine($"ID: {item.Toy_id}");
                Console.WriteLine($"Name: {item.Toy_name}");
                Console.WriteLine($"Size {item.Size}");
                Console.WriteLine($"Age: {item.Age}\n-------------------------");
            }
        }
        public static void ListAllBoardgames()
        {
            BoardGameController bgc = new BoardGameController();
            var boardGames = bgc.GetAllBoardGames();
            foreach (var item in boardGames)
            {
                Console.WriteLine($"Name: {item.Toy_name}");
                Console.WriteLine($"Number of Players: {item.NoP}");
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine($"Price: {item.Price}\n-------------------------");
            }
        }
        public static void ListAllSportToys()
        {
            SportsToysController sgc = new SportsToysController();
            var sportToys = sgc.GetAllSportToys();
            foreach (var item in sportToys)
            {
                Console.WriteLine($"Name: {item.ToyName}");
                Console.WriteLine($"Sport: {item.Sport}");
                Console.WriteLine($"Price: {item.Price}\\n-------------------------");
            }
        }
        public static void ListAllLegoSets()
        {
            LegoController lc = new LegoController();
            var legoSets = lc.GetAllLegoSets();
            foreach (var item in legoSets)
            {
                Console.WriteLine($"Name of Set: {item.Set_name}");
                Console.WriteLine($"Name of Series: {item.Series_name}");
                Console.WriteLine($"Age group: {item.Age_group}");
                Console.WriteLine($"Number of Bricks: {item.NoB}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Rating: {item.Rating}");
                Console.WriteLine($"In Stock?: {item.In_stock}");
                Console.WriteLine($"In Production?: {item.In_Production}\n-------------------------");
            }
        }

        public static void DeleteBabyToy()
        {
            BabyToyController babytoy = new BabyToyController(); Console.WriteLine("Enter the name of the toy you want to delete: ");
            string name = Console.ReadLine(); babytoy.DeleteBabyToyByName(name);
        }
        public static void EditBabyToy()
        {
            BabyToyController btc = new BabyToyController();
            Console.WriteLine("Enter the name of the toy you want to edit: ");
            string name = Console.ReadLine(); BabyToy babyToy = btc.GetBabyToyByName(name);
            Console.WriteLine("Enter new name:");
            string newname = Console.ReadLine();
            Console.WriteLine("Enter new price:");
            decimal newprice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter new age:");
            int newage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new size");
            string newsize = Console.ReadLine(); btc.EditBabyToy(babyToy, newname, newage, newsize, newprice);
        }
        public static void SearchBabyToyByAge()
        {
            BabyToyController btc = new BabyToyController();
            int age = int.Parse(Console.ReadLine());
            btc.SearchByAge(age);
        }
        public static void SearchBabyToyToyBySize()
        {
            BabyToyController btc = new BabyToyController();
            string size = Console.ReadLine();
            btc.SearchBysize(size);
        }

        //board game operations
        public static void AddBoardGame()
        {
            BoardGameController bgc = new BoardGameController();
            BoardGame boardGame = new BoardGame();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            Console.WriteLine("Enter number of players:");
            int nop = int.Parse(Console.ReadLine());
            if (nop <= 0)
            {
                Console.WriteLine("Number of players cannot be 0 or negative!");
                return;
            }
            Console.WriteLine("Enter price:");
            decimal price = decimal.Parse(Console.ReadLine()); if (price <= 0)
            {
                Console.WriteLine("Price cannot be 0 or negative!");
                return;
            }
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative!");
                return;
            }
            boardGame.Toy_name = name;
            boardGame.Age = age;
            boardGame.Price = price;
            boardGame.NoP = nop;
            bgc.AddBoardGame(boardGame);
        }
        public static void DeleteBoardGame()
        {
            BoardGameController boardGame = new BoardGameController(); Console.WriteLine("Enter the name of the board game you want to delete: ");
            string name = Console.ReadLine(); boardGame.DeleteBoardGameByName(name);
        }
        public static void EditBoardGame()
        {
            BoardGameController bgc = new BoardGameController();
            Console.WriteLine("Enter the name of the board game you want to edit: ");
            string name = Console.ReadLine(); BoardGame boardGame = bgc.GetBoardGameByName(name);
            Console.WriteLine("Enter new name:");
            string newname = Console.ReadLine();
            Console.WriteLine("Enter new price:");
            decimal newprice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter new age:");
            int newage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new NoP");
            
            int newNoP = int.Parse(Console.ReadLine());
            bgc.EditBoardGame(boardGame, newname, newNoP, newage, newprice);
        }

        public static void SearchBoardGameByAge()
        {
            BoardGameController bgc = new BoardGameController();
            int age = int.Parse(Console.ReadLine());
            bgc.SearchByAge(age);
        }
        public static void SearchBoardGameByNoP()
        {
            BoardGameController spt = new BoardGameController();
            int nop = int.Parse(Console.ReadLine());
            spt.SearchByNoP(nop);
        }

    }

}
