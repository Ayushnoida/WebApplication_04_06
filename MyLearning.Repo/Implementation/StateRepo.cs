using MyLearning.Entities.Models;
using MyLearning.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearning.Repo.Implementation
{
    public class StateRepo : IStateRepo
    {
        private readonly ProjectContext _context;

        public IEnumerable<IStateRepo> AllData()
        {
            var a = _context.State.ToList();
            return (IEnumerable<IStateRepo>)a;
            
        }

        public void CreateState(State state)
        {
            _context.Add(state);
            _context.SaveChanges();

        }

        public void DeleteState(State state)
        {
            _context.Remove(state);
            _context.SaveChanges();
        }

        public State GetState(int id)
        {
            return _context.State.Find(id);
        }

        public void UpdateState(State state)
        {
            _context.State.Update(state);
            _context.SaveChanges();
        }
    }
}
