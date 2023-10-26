using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_web_api.Models
{
    public class User
    {
        //id, meno, priezvisko, vek, datum narodenia

        public int Id {get; set;}
        public string Name {get; set;} = "Boris";
        public string Surname {get; set;} = "Gasparovic";
        public int Years {get; set;}
        public DateTime Birthdate {get; set;}
    }
}