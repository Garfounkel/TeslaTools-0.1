
using System;

namespace TeslaTools
{
    class Bingo
    {
        public Random rand;
        public string Seed;

        public Bingo()
        {
            rand = new Random();
        }

        public string GetRandomSeed()
        {
            return (rand.Next() % 100000).ToString();
        }
    }
}
