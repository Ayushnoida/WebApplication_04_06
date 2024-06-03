using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Entities.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string COuntryName{ get; set; }
        public ICollection<State> States{ get; set;}
    }
}
