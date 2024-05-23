using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class ItemListView

    {
        //properties
        List<Country> Countries = new List<Country>();


        //constructor
        public ItemListView(List<Country> _countries)
        { 
         
            Countries = _countries;
        
        }


        //method

        public void ViewList()
        {

            for (int i = 0; i < Countries.Count; i++)

            {
                Console.WriteLine(Countries[i]);


            }


        }


    }
}
