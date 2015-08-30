
using System;
using System.Diagnostics;

namespace TeslaTools
{
    class Bingo
    {
        private Random randSeed;
        private Random rand;

        public string Seed;

        public Bingo()
        {
            randSeed = new Random();
        }

        public string GetRandomSeed()
        {
            return (randSeed.Next() % 100000).ToString();
        }

        public void CreateRandFromSeed()
        {
            int intSeed = 0;
            foreach (char c in Seed)
            {
                intSeed += (c * c);
            }

            rand = new Random(intSeed);
            Debug.WriteLine("Seed: " + intSeed);
        }
    }
}
