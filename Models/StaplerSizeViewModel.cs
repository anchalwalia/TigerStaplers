using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TigerStaplers.Models
{
    public class StaplerSizeViewModel
    {
        public List<Stapler> Staplers { get; set; }
        public SelectList Size { get; set; }
        public string StaplerSize { get; set; }
        public string SearchString { get; set; }
    }
}