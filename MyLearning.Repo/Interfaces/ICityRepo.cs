using MyLearning.Entities.Models;
using MyLearning.Repo.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Repo.Interfaces
{
    public interface ICityRepo
    {
        IEnumerable<ICityRepo> AllData();
        CityRepo GetCity( int id);

        void CreateCity(Country country);
        void UpdateCity(Country country);
        void DeleteCity(Country country);
    }
}
