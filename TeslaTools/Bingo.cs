using System;
using System.Collections.Generic;

namespace TeslaTools
{
    class Bingo
    {
        private Random randSeed;
        private Random rand;

        public string Seed;
        public int IntSeed;
        public int NumberOfScrolls;
        public List<int> ScrollsList;


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
            IntSeed = 0;
            foreach (char c in Seed)
            {
                IntSeed += (c * c);
            }

            rand = new Random(IntSeed);
        }

        public List<int> GetRandomScrollList(int scrollNumber)
        {
            ScrollsList = new List<int>();
            CreateRandFromSeed();
            for (int i = 0; i < scrollNumber; i++)
            {
                int scroll = rand.Next(1, 37);
                if (ScrollsList.Contains(scroll))
                {
                    i--;
                }
                else
                {
                    ScrollsList.Add(scroll);
                }
            }

            return ScrollsList;
        }

        public string PrintScrolls()
        {
            string s = "";
            foreach (int i in ScrollsList)
            {
                s += (i) + ", ";
            }
            s = s.Remove(s.Length - 2);

            return s;
        }
    }
}
