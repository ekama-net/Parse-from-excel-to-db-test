using Microsoft.EntityFrameworkCore;

namespace AlgimedTask
{
    internal class Context : DbContext
    {
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = $"{mainForm.filePath }\\..\\AlgimedDb.db";
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
