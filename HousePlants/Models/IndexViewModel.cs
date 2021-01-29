using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousePlants.Models
{
    public class IndexViewModel
    {
        public List<Plant> plantList { get; set; }

        public IndexViewModel()
        {
            this.plantList = new List<Plant>();
        }
    }
}
