using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_View_Controller.Models
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Context(DbContextOptions<Context> opcoes) : base (opcoes)
        {

        }
    }
}
