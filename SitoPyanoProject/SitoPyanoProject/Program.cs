using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace SitoPyanoProject
{
    public class Program
    {
        public static void AddToStorage(string path)
        {
            List<string[]> input = FileReader(path);
            for (int i = 1; i < int.Parse(input[0][0]); i++)
            {
                if (input[i][0] == "Еда")
                {
                    Food exemplar = new Food(int.Parse(input[i][1]), double.Parse(input[i][2]), int.Parse(input[i][3]), input[i][4]);
                    Storage.AddProduct(exemplar);
                }
                else
                {
                    Beverages exemplar = new Beverages(input[i][1], int.Parse(input[i][2]), double.Parse(input[i][3]), int.Parse(input[i][4]), input[i][5]);
                    Storage.AddProduct(exemplar);
                }
            }
        }
        public static void AddToMenu(string path)
        {

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
            Console.WriteLine("Введите ссылку на список закупок");
            AddToStorage(Console.ReadLine());
        }
    }
}