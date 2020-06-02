using System;

namespace Mahjong.Models
{
    public class Tile
    {
        public string Type;
        public string Value;
        public bool IsHonorTile;

        public Tile(string type, string value, bool isHonorTile)
        {
            Type = type;
            Value = value;
            IsHonorTile = isHonorTile;
        }

        public void Display()
        {
            if(IsHonorTile)
            {
                Console.WriteLine($"The {Value} {Type}");
            }
            else
            {
                Console.WriteLine($"The {Value} of {Type}");
            }
        }

    }
}