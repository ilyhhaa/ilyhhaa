using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ForEntity
{
    public class Beer:InfoClass
    {
        public int BreweryId { get; set; } //Внешний ключ

        Brewery Brewery { get; set; }



        
    }
}
