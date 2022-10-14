using System;
using System.ComponentModel.DataAnnotations;


namespace TigerStaplers.Models
{
    public class Stapler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        public string Material { get; set; }

        public decimal Price { get; set; }
        public int PinsIncluded { get; set; }
    }
}
