using System;
using System.Collections.Generic;

namespace Mahjong.Models
{
    public class Set
    {
        private List<Tile> Tiles = new List<Tile>();

        public Set() 
        {

            // winds:      🀀 🀁 🀂 🀃 
            // dragons:    🀄 🀅 🀆 
            // characters: 🀇 🀈 🀉 🀊 🀋 🀌 🀍 🀎 🀏 
            // bamboo:     🀐 🀑 🀒 🀓 🀔 🀕 🀖 🀗 🀘 
            // pin:        🀙 🀚 🀛 🀜 🀝 🀞 🀟 🀠 🀡 

            // 索子  筒子  萬子
            string[] suits   = new string[]{"Bamboo", "Pins", "Characters"};
            // 一 二 三 四 五 六 七 八 九
            string[] values  = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            // 東 南 西 北
            string[] winds   = new string[]{"East", "South", "West", "North"};
            // 中 發 白   
            string[] dragons = new string[]{"Red", "Green", "White"};

            foreach(string suit in suits)
            {
                foreach(string val in values)
                {
                    Tiles.Add(new Tile(suit, val, false));
                    Tiles.Add(new Tile(suit, val, false));
                    Tiles.Add(new Tile(suit, val, false));
                    Tiles.Add(new Tile(suit, val, false));
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