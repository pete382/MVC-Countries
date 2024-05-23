using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {   //property
        Country DisplayCountry { get; set; }

        //constructor
        public CountryView(Country _displaycountry)

        { DisplayCountry = _displaycountry}

        
        //method
        public void ViewSingle()
        {
            
            Console.WriteLine($"{DisplayCountry.Name}{DisplayCountry.Continent}{DisplayCountry.Colors}");

        }
    }
}
