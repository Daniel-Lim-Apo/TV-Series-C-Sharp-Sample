using System;
using System.Collections.Generic;
using System.IO;
using TV_Series_C_Sharp_Sample.Domain;
using TV_Series_C_Sharp_Sample.Infra;
using TV_Series_C_Sharp_Sample.Infra.Data;

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
            Console.Write("Type the serie number: ");
            int id = int.Parse(Console.ReadLine());
            Serie serie = serieRepository.GetById(id);       

            Console.WriteLine(serie);

        }

        private static void DeleteSeries()
        {
            Console.Write("Type the serie number: ");
            int id = int.Parse(Console.ReadLine());
            serieRepository.Delete(id);
        }

        private static void UpdateSerie()
        {
            Console.Write("Type the serie number: ");
            int _id = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Category))){
                Console.WriteLine("{0}-{1}", 1, Enum.GetName(typeof(Category),i));
            }

            Console.Write("Choose the category number from above: ");
            int _category = int.Parse(Console.ReadLine());

            Console.Write("Write the title: ");
            String _title = Console.ReadLine();

            Console.Write("Write the start year: ");
            String _year = Console.ReadLine();

            Console.Write("Write the description: ");
            String _description = Console.ReadLine();

            Serie _serie = new Serie(_id, _category, _title, _description, false);

            serieRepository.Update(_serie);

        }

        private static void InsertSerie()
        {
            Console.Write("Type the serie number: ");
            int _id = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Category))){
                Console.WriteLine("{0}-{1}", 1, Enum.GetName(typeof(Category),i));
            }

            Console.Write("Choose the category number from above: ");
            int _category = int.Parse(Console.ReadLine());

            Console.Write("Write the title: ");
            String _title = Console.ReadLine();

            Console.Write("Write the start year: ");
            String _year = Console.ReadLine();

            Console.Write("Write the description: ");
            String _description = Console.ReadLine();

            Serie _serie = new Serie(_id, _category, _title, _description, false);

            serieRepository.Update(_serie);        }

        private static void ListSeries()
        {
            Console.Write("Series List: ");
            
            IEnumerable<Serie> seriesList = serieRepository.GetAll();

            if (seriesList.Count() = 0)
            {
                Console.Write("No series listed.");
            }
            else
            {
                foreach(Serie serie in seriesList){
                    Console.WriteLine("ID: {0} - {1} {2}", serie.GetById, serie.GetTitle, serie.GetExcluded ? "* EXCLUDED *" : "" );

                }

            }



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

            String userOption = Console.ReadLine();
            Console.WriteLine("Aqui");
            return userOption;

        }
    }
}
