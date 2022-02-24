using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    internal class CountryController
    {
        List<Country>CountryDb { get; set; }

        public CountryController()
        {

            CountryDb = new List<Country>()
            {
                new Country("United States", "North America", new List<string>(){"Red, White, & Blue"}),
                new Country("France", "Europe", new List<string>(){"Blue, White, & Red"}),
                new Country("Saxony", "Europe", new List<string>(){"Black & Yellow"}),
                new Country("Crimera", "Europe", new List<string>(){"Green & Yellow"}),
                new Country("Tokogawa", "Asia", new List<string>(){"Purple & White"}),
                new Country("Spain", "Intercontinental", new List<string>(){"Red & Yellow"}),
                new Country("Brazil", "South America",new List<string>(){"Green, Yellow, & Blue"})
            };
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine($"Hello, welcome to the country app. Please select a country from the following list.");
            clv.Display();
        }

        public void ChooseCountry()
        {
            int countryChoice = 0;
            Console.WriteLine();
            Console.WriteLine("Enter a number to select a country from the list.");
            while (!int.TryParse(Console.ReadLine(), out countryChoice))
            {
                Console.Write("Not a valid option. Please try again: ");
            }
            Country chosenCountry = CountryDb[countryChoice];
            CountryAction(chosenCountry);

            Console.WriteLine(chosenCountry.Name);
            foreach (string c in chosenCountry.Colors)
            {
                Console.WriteLine(c);
            }
        }
    }
}
