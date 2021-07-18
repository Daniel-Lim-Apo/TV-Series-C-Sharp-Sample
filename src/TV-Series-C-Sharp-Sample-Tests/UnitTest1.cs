using System;
using Xunit;
using TV_Series_C_Sharp_Sample.Class;

namespace TV_Series_C_Sharp_Sample_Tests
{
    public class SerieTests
    {
        [Fact]
        public void Serie_With_a_New_Serie_Register_Insert()
        {
            // Arrange
            Serie serie = new Serie();
            
            // Act
            serie.Insert(serie);

            // Assert
            Assert.Contains(serie, serie.ListGetSerieInfo(serie.Id)
                
        }

        public void SeriesListSeries(){
            //Arrange
            Serie serie1 = new Serie(1, "TV Serie Name One", "Serie The One TV", 1991);

            Serie serie2 = new Serie(3, "TV Serie Name Two", "Serie The TV Two", 2005);

            Serie serie3 = new Serie(4, "TV Serie Name Three", "Three Serie TV", 2021);

            SerieRepository serieRepository = new SerieRepository();
            
            IEnumerable<Serie> series = serieRepository.GetAll();


            //Act

            //Assert

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

    }
}
