using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class LottoContext:DbContext
    {
        public DbSet<ClassLibrary.Model.Tipp> Tipp { get; set; } = default!;

        public DbSet<ClassLibrary.Model.Jatekos>? Jatekos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=(localdb)\\mssqllocaldb;Database=API.Data;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }

        public LottoContext()
        {
        }
    }
}
