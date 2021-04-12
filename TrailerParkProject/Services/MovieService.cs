using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkProject.Context;
using TrailerParkProject.Models;

namespace TrailerParkProject.Services
{
    public class MovieService
    {
        private readonly DatabaseContext _db;

        public MovieService(DatabaseContext db)
        {
            _db = db;
        }

        public List<Movies> GetAll()
        {
            return _db.Movies.ToList();
        }
    }
}
