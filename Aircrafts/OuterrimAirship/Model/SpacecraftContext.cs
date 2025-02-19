using Microsoft.EntityFrameworkCore;

namespace OuterrimAirship.Model;

public class SpacecraftContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Spacecraft> Spacecrafts { get; set; }
    public DbSet<Crew> Crews { get; set; }
    public DbSet<Compartment> Compartments { get; set; }
    public DbSet<CrimeSyndicate> CrimeSyndicates { get; set; }
    public DbSet<Mercenary> Mercenaries { get; set; }
    public DbSet<MercenaryReputation> MercenaryReputations { get; set; }
    public DbSet<Machinery> Machineries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 1...n CrimeSyndicate - MercenaryReputations
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(m => m.CrimeSyndicate)
            .WithMany(c => c.MercenaryReputations)
            .HasForeignKey(m => m.CrimeSyndicateId);
        
        // 1...n Mercenary - MercenaryReputations
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(m => m.Mercenary)
            .WithMany(m => m.MercenaryReputations)
            .HasForeignKey(m => m.MercenaryId);
        
        // Primary Key for MercenaryReputations
        modelBuilder.Entity<MercenaryReputation>()
            .HasKey(m => new { m.CrimeSyndicateId, m.MercenaryId });
        
        // 1...n SpacecraftSpecification - Spacecrafts
        modelBuilder.Entity<Spacecraft>()
            .HasOne(s => s.SpacecraftSpecification)
            .WithMany(s => s.Spacecrafts)
            .HasForeignKey(s => s.SpacecraftSpecificationId);
        
        // 1...n Spacecraft - Crews
        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Mercenary)
            .WithMany(m => m.Crews)
            .HasForeignKey(c => c.MercenaryId);
        
        // 1...n Mercenary - Crews
        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Spacecraft)
            .WithMany(s => s.Crews)
            .HasForeignKey(c => c.SpacecraftId);
        
        // Primary Key for Crews
        modelBuilder.Entity<Crew>()
            .HasKey(c => new {c.MercenaryId, c.SpacecraftId });
        
        // 1...n Spacecraft - Compartments
        modelBuilder.Entity<Compartment>()
            .HasOne(c => c.Spacecraft)
            .WithMany(c => c.Compartments)
            .HasForeignKey(c => c.SpacecraftId);
        
        // 1...n Compartments - Machinery
        modelBuilder.Entity<Machinery>()
            .HasOne(s => s.Compartments)
            .WithMany(s => s.Machineries)
            .HasForeignKey(s => s.CompartmentId);
        
        // Machinery Discriminator
        modelBuilder.Entity<Machinery>().HasDiscriminator<string>("Type")
            .HasValue<EnergySystem>("EnergySystem")
            .HasValue<Weapon>("Weapon")
            .HasValue<EnvironmentalSystem>("EnvironmentalSystem");
    }
}