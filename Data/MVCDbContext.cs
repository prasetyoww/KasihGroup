using Microsoft.EntityFrameworkCore;
using PendaftaranPasien.Models.Domain;

namespace PendaftaranPasien.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Pasien> Pasiens { get; set; }
    }
}
