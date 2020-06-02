using System;
using System.Collections.Generic;

namespace Mahjong.Models
{
    public class Set
    {
        // TODO - should this be public?
        public List<Tile> Tiles = new List<Tile>();

        public Set() 
        {

            string[] classes = new string[]{"Bamboo", "Pins", "Characters"};
            string[] values = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            string[] winds = new string[]{"East", "South", "West", "North"};
            string[] dragons = new string[]{"Red", "Green", "White"};

            foreach(string _class in classes)
            {
                foreach(string val in values)
                {
                    Tiles.Add(new Tile(_class, val, false));
                    Tiles.Add(new Tile(_class, val, false));
                    Tiles.Add(new Tile(_class, val, false));
                    Tiles.Add(new Tile(_class, val, false));
                }
            }

            foreach(string wind in winds)
            {
                Tiles.Add(new Tile("Wind", wind, true));
                Tiles.Add(new Tile("Wind", wind, true));
                Tiles.Add(new Tile("Wind", wind, true));
                Tiles.Add(new Tile("Wind", wind, true));
            }
            
            foreach(string dragon in dragons)
            {
                Tiles.Add(new Tile("Dragon", dragon, true));
                Tiles.Add(new Tile("Dragon", dragon, true));
                Tiles.Add(new Tile("Dragon", dragon, true));
                Tiles.Add(new Tile("Dragon", dragon, true));
            }

        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i=0; i<Tiles.Count; i++) 
            {
                int randIndex = rand.Next(Tiles.Count);
                Tile temp = Tiles[i];
                Tiles[i] = Tiles[randIndex];
                Tiles[randIndex] = temp;
            }
        }

        public List<Tile> Deal(int number = 13)
        {
            List<Tile> Hand = new List<Tile>();
            for(int i=0; i<number; i++) 
            {
                Tile t = Tiles[0];
                Tiles.Remove(t);
                Hand.Add(t);
            }
            return Hand;
        }

    }
}