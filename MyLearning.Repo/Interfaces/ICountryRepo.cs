using MyLearning.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLearning.Entities;

namespace MyLearning.Repo.Interfaces
{
    public  interface ICountryRepo
    {
        IEnumerable<Country> AllData() ;
         Country GetCountry(int id);

        void CreateCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(Country country);

    }
}
