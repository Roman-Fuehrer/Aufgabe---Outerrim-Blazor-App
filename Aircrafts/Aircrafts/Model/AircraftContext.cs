using Microsoft.EntityFrameworkCore;

namespace Aircrafts.Model;

public class AircraftContext : DbContext
{
    public AircraftContext(DbContextOptions options) : base(options) { }
}