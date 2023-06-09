﻿using System;
using System.Globalization;
using Lego_and_other_toys_Project.Controllers;
using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using Lego_and_other_toys_Project.Input;

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
                                more1= Console.ReadLine();
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
                                       string  more4 = Console.ReadLine();
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
    }
}
