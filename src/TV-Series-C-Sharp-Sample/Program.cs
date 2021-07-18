using System;
using TV_Series_C_Sharp_Sample.Class;
using TV_Series_C_Sharp_Sample.Infra;

namespace TV_Series_C_Sharp_Sample
{
    class Program
    {
        static SerieRepository serieRepository = new SerieRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                case "1":
                    ListSeries();
                    break;    
                case "2":
                    InsertSerie();
                    break;    
                case "3":
                    UpdateSerie();
                    break;    
                case "4":
                    DeleteSeries();
                    break;    
                case "g":
                    GetSerieInfo();
                    break;    
                case "C":
                    Console.Clear();
                    break;    
                
                default:
                    throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOption();

            }

        }

        private static void GetSerieInfo()
        {
            throw new NotImplementedException();
        }

        private static void DeleteSeries()
        {
            throw new NotImplementedException();
        }

        private static void UpdateSerie()
        {
            throw new NotImplementedException();
        }

        private static void InsertSerie()
        {
            throw new NotImplementedException();
        }

        private static void ListSeries()
        {
            throw new NotImplementedException();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("TV Series Sample - Options");
            Console.WriteLine("Let me know your option: ");

            Console.WriteLine("1 - List Series");
            Console.WriteLine("2 - Insert Serie");
            Console.WriteLine("3 - Update Serie");
            Console.WriteLine("4 - Get Serie Info");
            Console.WriteLine("C - Clear Screen");
            Console.WriteLine("X - eXit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;

        }
    }
}
