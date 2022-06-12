using DietaFacil.Models;
using Microsoft.EntityFrameworkCore;

namespace DietaFacil.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<MeusAlimentosModel> MeusAlimentos { get; set; }
    }
}
