using MyLearning.Entities.Models;
using MyLearning.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Repo.Implementation
{
    public class CityRepo : ICityRepo
    {
        private readonly ProjectContext _context;

        public CityRepo(ProjectContext context)
        {
            _context = context;
        }

        public IEnumerable<ICityRepo> AllData()
        {
            throw new NotImplementedException();
        }

        public void CreateCity(Country country)
        {
            throw new NotImplementedException();
        }

        public void DeleteCity(Country country)
        {
            throw new NotImplementedException();
        }

        public CityRepo GetCity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
