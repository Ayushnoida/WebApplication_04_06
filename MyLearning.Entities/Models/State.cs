using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Entities.Models
{
    public class State
    {
        public int StateId{ get; set; }
        public string? StateName { get; set; }   

        public int CountryId { get; set; } 
        public Country? CountryName { get; set; } 
         public ICollection<City> Citys { get; set; }
        
    }
}
