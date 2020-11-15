using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace SitoPyanoProject
{
    public class Program
    {
        /*public bool GetOrder()
        {
            if(Stao)
        }*/
        public static Menu menu = new Menu();
        public static Storage storage = new Storage();
        public static void AddToStorage(string path)
        {
            List<string[]> input = FileReader(path);
            for (int i = 1; i < int.Parse(input[0][0])+1; i++)
            {
                if (input[i][0] == "Еда")
                {
                    Food exemplar = new Food(int.Parse(input[i][1]), double.Parse(input[i][2]), int.Parse(input[i][3]), input[i][4]);
                    storage.AllProducts.Add(exemplar);
                }
                else
                {
                    Beverages exemplar = new Beverages(input[i][1], int.Parse(input[i][2]), double.Parse(input[i][3]), int.Parse(input[i][4]), input[i][5]);
                    storage.AllProducts.Add(exemplar);
                }
            }
        }
        public static void AddToMenu(string path)
        {
            List<string[]> input = FileReader(path);
            for (int i = 1; i < int.Parse(input[0][0])+1; i++)
            {
                if (input[i][0] == "Блюдо")
                {
                    Dish exemplar = new Dish(input[i][1], double.Parse(input[i][2]), ReturnComponents(input[i]), storage);
                    menu.Add(exemplar);
                }
                else
                {
                    Cocktail exemplar = new Cocktail(input[i][1], double.Parse(input[i][2]), ReturnComponents(input[i]), storage);
                    menu.Add(exemplar);
                }
            }
        }
        public static List<string> ReturnComponents(string[] input)
        {
            List<string> returner = new List<string>();
            for (int i = 3; i < input.Length; i++)
            {
                returner.Add(input[i]);
            }
            return returner;
        }
        public static List<string[]> FileReader(string path)
        {
            StreamReader rdr = new StreamReader(path);
            string fileLine;
            List<string[]> input = new List<string[]>();
            while ((fileLine = rdr.ReadLine()) != null)
            {
                input.Add(fileLine.Split(' '));
            }
            return input;
        }
        static void Main(string[] args)
        {
            AddToStorage(Path.Combine("./../../../../Storage.txt"));
            AddToMenu("./../../../../Menu.txt");
            Console.WriteLine(menu);
        }
    }
}