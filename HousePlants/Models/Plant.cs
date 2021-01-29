using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousePlants.Models
{
    public class Plant
    {

        public long id { get; set; }
        public string name { get; set; }
        public string sun { get; set; }
        public string image { get; set; }
        public string water { get; set; }
        public string fertilize { get; set; }


        public Plant(string name, string sun, string image, string water, string fertilize)
        {
            this.name = name;
            this.sun = sun;
            this.image = image;
            this.water = water;
            this.fertilize = fertilize;
        }
    }
}
