using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }
        public CountryListView(List<Country>countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            foreach(Country c in Countries)
            {
                int index = Countries.IndexOf(c);
                Console.WriteLine($"{index}: {c.Name}");
            }
        }

    }
}
