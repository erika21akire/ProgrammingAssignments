using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleSong
{
    internal class BeerSong
    {
        public static string Lyrics()
        {
            int Lyric = 99;

            for (int i = Lyric; i > 0; i--)
            {
                Console.WriteLine($"{i} bottle{(i == 1 ? "" : "s")} of beer on the wall, {i} bottle{(i == 1 ? "" : "s")} of beer.");
                Console.WriteLine($"Take one down and pass it around, {i - 1} bottle{(i == 2 ? "" : "s")} of beer on the wall.\n");
                Thread.Sleep(300);
            }
            return "";
        }
    }
}
