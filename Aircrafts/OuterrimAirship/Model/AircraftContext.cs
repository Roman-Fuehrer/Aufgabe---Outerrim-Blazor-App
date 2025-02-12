using Microsoft.EntityFrameworkCore;

namespace OuterrimAirship.Model;

public class AircraftContext : DbContext
{
    public AircraftContext(DbContextOptions options) : base(options) { }

    public DbSet<Aircraft> Aircrafts { get; set; }
    public DbSet<Crew> Crews { get; set; }
    public DbSet<Compartment> Compartments { get; set; }
    public DbSet<CrimeSyndicate> CrimeSyndicates { get; set; }
    public DbSet<Mercenary> Mercenaries { get; set; }
    public DbSet<MercenaryReputation> MercenaryReputations { get; set; }
    public DbSet<Machinery> Machineries { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}