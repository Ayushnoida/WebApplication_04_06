using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MyLearning.Entities.Models;

namespace MyLearning.Repo
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
    }
}
