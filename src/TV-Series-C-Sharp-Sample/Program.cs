using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TV_Series_C_Sharp_Sample.Domain;
using TV_Series_C_Sharp_Sample.Enum;
using TV_Series_C_Sharp_Sample.Infra;


namespace TV_Series_C_Sharp_Sample
{
    class Program
    {
        static SerieRepository serieRepository = new SerieRepository();
        async Task Main(string[] args)
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
                    case "5":
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

        private async void GetSerieInfo()
        {
            Console.Write("Type the serie number: ");
            int id = int.Parse(Console.ReadLine());
            Serie _serie = await serieRepository.GetById(id);       

            Console.WriteLine(_serie);
        }

        private async void DeleteSeries()
        {
            Console.Write("Type the serie number: ");
            int id = int.Parse(Console.ReadLine());
            await serieRepository.Delete(id);
        }

        private async static void UpdateSerie()
        {

            Console.WriteLine("See the series to update: ");

            await ListSeriesAsync();

            List<Serie> seriesList = await serieRepository.GetAll();

            if(seriesList.Count() < 1) {
                Console.WriteLine("There are no series to update. Please, choose another option.");
            }
            else
            {

                Console.Write("Type the serie number that you want to update: ");
                int _id = int.Parse(Console.ReadLine());

                foreach (int i in System.Enum.GetValues(typeof(Category))){
                    Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Category), i));
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

                await serieRepository.Update(_serie);
            }
        }

        private async void InsertSerie()
        {
            Console.Write("Type the serie number: ");
            int _id = int.Parse(Console.ReadLine());

            foreach (int i in System.Enum.GetValues(typeof(Category))){
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Category),i));
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

            serieRepository.GetById .Add(_serie);  

        }

        public async static Task ListSeriesAsync()
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

        private string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("TV Series Sample - Options");
            Console.WriteLine("Let me know your option: ");

            Console.WriteLine("1 - List Series");
            Console.WriteLine("2 - Insert Serie");
            Console.WriteLine("3 - Update Serie");
            Console.WriteLine("4 - Delete Serie");
            Console.WriteLine("5 - Get Serie Info");
            Console.WriteLine("C - Clear Screen");
            Console.WriteLine("X - eXit");
            Console.WriteLine();

            String userOption = Console.ReadLine();
            
            return userOption;

        }
    }
}
