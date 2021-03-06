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

        public Movies GetById(int id)
        {
            return _db.Movies.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Movies movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }

        public void Update(Movies movie)
        {
            _db.Movies.Update(movie);
            _db.SaveChanges();
        }

        public void Delete(Movies movie)
        {
            _db.Movies.Remove(movie);
            _db.SaveChanges();
        }
    }
}
