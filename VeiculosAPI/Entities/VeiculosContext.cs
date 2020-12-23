using System;
using Microsoft.Extensions.Configuration;


namespace VeiculosAPI.Entities
{
    public partial class VeiculosContext : DbContext
    {
        private IConfiguration _configuration;

        public VeiculosContext()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public virtual DbSet<Carro> Carro { get; set; }
        public virtual DbSet<Moto> Moto { get; set; }
        public virtual DbSet<Caminhao> Caminhao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_configuration.GetConnectionSring("DefaultConnection"), o => o.SetPostgresVersion(9,6));
            }
        }
    }
}