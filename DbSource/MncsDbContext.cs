using mncs.DbModel;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mncs.DbSource
{
    public class MncsDbContext : DbContext
    {
        public MncsDbContext() : base("mncs")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Programmer>();
            modelBuilder.Entity<ProjectManager>();
            Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<MncsDbContext>(modelBuilder));
        }

        public DbSet<Programmer> Programmers { get { return Set<Programmer>(); } }
        public DbSet<ProjectManager> ProjectManagers { get { return Set<ProjectManager>(); } }
    }
}
