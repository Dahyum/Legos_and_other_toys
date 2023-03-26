using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project.Controllers
{
    public class BoardGameController
    {
        private ToyStoreContext context;
        public BoardGameController()
        {
            context = new ToyStoreContext();
        }
        public void SearchByAge(int age)
        {
            List<BoardGame> sets = context.BoardGames.Where(x => x.Age >= age).ToList();
            if (age <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name: {item.Toy_name}");
                Console.WriteLine($"Number of Players: {item.NoP}");
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine($"Price: {item.Price}\n-------------------------");
            }
        }
            
        
        public void SearchByNoP(int noP)
        {
            List<BoardGame> sets = context.BoardGames.Where(x => x.NoP >= noP).ToList();
            if (noP <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name: {item.Toy_name}");
                Console.WriteLine($"Number of Players: {item.NoP}");
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine($"Price: {item.Price}\n-------------------------");
            }
        }
        public void AddBoardGame(BoardGame boardGame)
        {
            context.Add(boardGame);
            context.SaveChanges();
        }
        public BoardGame GetBoardGameByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            BoardGame boardGame = context.BoardGames.FirstOrDefault(x => x.Toy_name == name);
            if (boardGame == null)
            {
                throw new ArgumentException("No toy found with this name!");
            }
            return boardGame;
        }
        public void DeleteBoardGameByName(string name)
        {
            BoardGame boardgametodelete = GetBoardGameByName(name);
            context.Remove(boardgametodelete);
            context.SaveChanges();
        }
        public void EditBoardGame(BoardGame boardGame, string newname, int nop, int newage, decimal newprice)
        {
            boardGame.Toy_name = newname;
            boardGame.NoP = nop;
            boardGame.Age = newage;
            boardGame.Price = newprice;
            context.Update(boardGame);
            context.SaveChanges();
        }
    }
}
