using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TigerStaplers.Models
{
    public class Stapler
    {
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        public string Material { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int PinsIncluded { get; set; }

        [Range(0, 5)]
        [Column(TypeName = "decimal(2, 1)")]
        public decimal Rating { get; set; }
    }
}
