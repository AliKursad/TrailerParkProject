using System;
using System.Collections.Generic;

namespace TrailerParkProject.Models
{
    public partial class MovieCastRelation
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CastId { get; set; }
    }
}
