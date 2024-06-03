using MyLearning.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Repo.Interfaces
{
   public interface IStateRepo
    {
        IEnumerable<IStateRepo> AllData();
        State GetState(int id);

        void CreateState(State state);
        void UpdateState(State state);
        void DeleteState(State state);
    }
}
