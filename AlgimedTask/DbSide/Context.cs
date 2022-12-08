using Microsoft.EntityFrameworkCore;
using System;

namespace AlgimedTask
{
    internal class Context : DbContext
    {
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = $"{mainForm.filePath }\\..\\sec\\AlgimedDb.db";          
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
