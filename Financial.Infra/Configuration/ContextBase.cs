using Financial.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Financial.Infra.Configuration
{
    public class ContextBase : DbContext
    {
        public DbSet<FinancialMovement> FinancialMovements { get; set; }

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            //Database.EnsureCreated(); <-> parece que isso aqui é pra quando usa codefirst, vou usar Migration
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
            base.OnConfiguring(optionsBuilder);
        }
        private string GetStringConnectionConfig()
        {
            return "Data Source=.; Initial Catalog=FINCONTROL; Integrated Security=False; User ID=sa; Password=sic742";
        }
    }
}
