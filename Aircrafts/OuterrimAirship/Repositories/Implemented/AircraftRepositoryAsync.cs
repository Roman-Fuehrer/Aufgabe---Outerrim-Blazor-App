using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class AircraftRepositoryAsync : ARepositoryAsync<Spacecraft>
{
    public AircraftRepositoryAsync(SpacecraftContext context) : base(context) { }
}