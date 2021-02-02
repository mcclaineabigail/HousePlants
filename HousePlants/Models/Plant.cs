
using System;
using System.ComponentModel.DataAnnotations;
using HousePlants.Data;

namespace HousePlants.Models
{
    public class Plant : IEntity
    {

        public int Id { get; set; }


        //[Required] 
        public string Name { get; set; }
        //[Required] 
        public string Sun { get; set; }
        //[Required]
        public string Image { get; set; }
        //[Required]
        public string Water { get; set; }
        //[Required]
        public string Notes { get; set; }


        //public Plant(string name, string sun, string image, string water, string Notes)
        //{
        //    this.Name = name;
        //    this.Sun = sun;
        //    this.Image = image;
        //    this.Water = water;
        //    this.Notes = Notes;
        //}
    }
}
