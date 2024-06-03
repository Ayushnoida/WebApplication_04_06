using MyLearning.Entities.Models;
using MyLearning.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Repo.Implementation
{
    public class CountryRepo : ICountryRepo
    {
        private readonly ProjectContext _context;

        public CountryRepo(ProjectContext context)
        {
            this._context = context;
        }

        public IEnumerable<Country> AllData()
        {
            var a = _context.Country.ToList();
            return a;

           // throw new NotImplementedException();
        }

        public void CreateCountry( Country country)
        {
            _context.Add(country);
            _context.SaveChanges();
            

          //  throw new NotImplementedException();
        }

        public void DeleteCountry(Country country)
        {
            _context.Remove(country);
            _context.SaveChanges();
           // throw new NotImplementedException();
        }

        public Country GetCountry(int id)
        {

            return _context.Country.Find(id);
            // throw new NotImplementedException();
        }

        public void UpdateCountry(Country country)
        {
            _context.Country.Update(country);
            _context.SaveChanges();
          //  throw new NotImplementedException();
        }
    }
}
