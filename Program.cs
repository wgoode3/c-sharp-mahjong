using System;
using System.Collections.Generic;
using Mahjong.Models;

namespace Mahjong
{
    class Program
    {
        static void Main(string[] args)
        {
            Set s1 = new Set();
            s1.Shuffle();
            List<Tile> Hand = s1.Deal();
            foreach(Tile t in Hand)
            {
                t.Display();
            }
        }
    }
}
