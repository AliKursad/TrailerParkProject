using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkProject.Context;
using TrailerParkProject.Models;

namespace TrailerParkProject.Services
{
    public class CastService
    {
        private readonly DatabaseContext _db;

        public CastService(DatabaseContext db)
        {
            _db = db;
        }

        public List<Cast> GetAll()
        {
            return _db.Cast.ToList();
        }

        public Cast GetById(int id)
        {
            return _db.Cast.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Cast cast)
        {
            _db.Cast.Add(cast);
            _db.SaveChanges();
        }
        public void Update(Cast cast)
        {
            _db.Cast.Update(cast);
            _db.SaveChanges();
        }
        public void Delete(Cast cast)
        {
            _db.Cast.Remove(cast);
            _db.SaveChanges();
        }
    }
}
