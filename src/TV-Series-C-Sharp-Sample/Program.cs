using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TV_Series_C_Sharp_Sample.Domain;
using TV_Series_C_Sharp_Sample.Enum;
using TV_Series_C_Sharp_Sample.Infra;
using TV_Series_C_Sharp_Sample.Infra.Data;

namespace TV_Series_C_Sharp_Sample
{
    class Program
    {
        static SerieRepository serieRepository = new SerieRepository();
        static async Task Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        await ListSeriesAsync();
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

        private async static void GetSerieInfo()
        {
            Console.Write("Type the serie number: ");
            int id = int.Parse(Console.ReadLine());
            Serie serie = await serieRepository.GetById(id);       

            Console.WriteLine(serie);

        }

        private async static void DeleteSeries()
        {
            Console.Write("Type the serie number: ");
            int id = int.Parse(Console.ReadLine());
            await serieRepository.Delete(id);
        }

        private static void UpdateSerie()
        {
            Console.Write("Type the serie number: ");
            int _id = int.Parse(Console.ReadLine());

            foreach (int i in System.Enum.GetValues(typeof(Category))){
                Console.WriteLine("{0}-{1}", 1, System.Enum.GetName(typeof(Category),i));
            }

            Console.Write("Choose the category number from above: ");
            int _categoryNumber = int.Parse(Console.ReadLine());

            Console.Write("Write the title: ");
            String _title = Console.ReadLine();

            Console.Write("Write the start year: ");
            int _year = int.Parse(Console.ReadLine());

            Console.Write("Write the description: ");
            String _description = Console.ReadLine();

            Serie _serie = new Serie(_id, _categoryNumber, _title, _description, _year);

            serieRepository.Update(_serie);

        }

        private static void InsertSerie()
        {
            Console.Write("Type the serie number: ");
            int _id = int.Parse(Console.ReadLine());

            foreach (int i in System.Enum.GetValues(typeof(Category))){
                Console.WriteLine("{0}-{1}", 1, System.Enum.GetName(typeof(Category),i));
            }

            Console.Write("Choose the category number from above: ");
            int _categoryNumber = int.Parse(Console.ReadLine());

            Console.Write("Write the title: ");
            String _title = Console.ReadLine();

            Console.Write("Write the start year: ");
            int _year = int.Parse(Console.ReadLine());

            Console.Write("Write the description: ");
            String _description = Console.ReadLine();

            Serie _serie = new Serie(_id, _categoryNumber, _title, _description, _year);

            serieRepository.Update(_serie);        }

        private static async Task ListSeriesAsync()
        {
            Console.Write("Series List: ");
            
            List<Serie> seriesList = await serieRepository.GetAll();

            Console.WriteLine();

            if (seriesList.Count<Serie>() == 0)
            {
                Console.WriteLine("No series listed.");
            }
            else
            {
                foreach(Serie serie in seriesList){

                    Console.WriteLine("ID: {0} - {1} {2}", serie.GetId(), serie.GetTitle(), serie.GetExcluded() ? "* EXCLUDED *" : "" );

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
            
            return userOption;

        }
    }
}
