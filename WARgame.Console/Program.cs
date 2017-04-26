using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WARgame.Console.Classes;

namespace WARgame.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Bridget", "Josh");
            game.Deal();
            game.Play();
        }
    }
}
