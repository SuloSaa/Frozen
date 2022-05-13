using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class ChirstmasWish // Movie oli  Movie = ChristmasWish
        {
            string name; //Oli title  taeteing ja year
            string wish;
            

            public ChirstmasWish(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
                
            }

            // getters for movie
            public string Name
            {
                get { return name; }
            }
            public string Wish
            {
                get { return wish; }
            }

        }
        static void Main(string[] args)
        {
            List<ChirstmasWish> myList = new List<ChirstmasWish>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                ChirstmasWish newWish = new ChirstmasWish (tempArray[0], tempArray[1]);
                myList.Add(newWish);
            }

            foreach (ChirstmasWish WishFromList in myList)
            {
                Console.WriteLine($"Name --> {WishFromList.Name}, wishes for Christmas :  {WishFromList.Wish}.");
            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Sulo\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
