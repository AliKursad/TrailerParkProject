using System;
using System.Collections.Generic;

namespace TrailerParkProject.Models
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public string DirectorName { get; set; }
        public string Description { get; set; }
        public string TrailerLink { get; set; }
    }
}
