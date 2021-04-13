using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkProject.Context;
using TrailerParkProject.Models;

namespace TrailerParkProject.Services
{
    public class CategoryService
    {
        private readonly DatabaseContext _db;

        public CategoryService(DatabaseContext db)
        {
            _db = db;
        }

        public List<Categories> GetAll()
        {
            return _db.Categories.ToList();
        }

        public Categories GetById(int id)
        {
            return _db.Categories.FirstOrDefault(p => p.Id == id);
        }

        public List<MovieCategoryRelation> GetMovieCategoriesByMovieId(int id)
        {
            return _db.MovieCategoryRelation.Where(p => p.MovieId == id).ToList();
        }

        public void Add(Categories category)
        {
            _db.Add(category);
            _db.SaveChanges();
        }

        public void Update(Categories category)
        {
            _db.Update(category);
            _db.SaveChanges();
        }

        public void Delete(Categories category)
        {
            _db.Remove(category);
            _db.SaveChanges();
        }
    }
}
