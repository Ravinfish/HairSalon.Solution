using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models;
  public class HairSalonContext : DbContext
  {
    // public DbSet<Salon> Salons { get; set; }
    public DbSet<Stylist> Stylists { get; set; }

    public DbSet<Client> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }