using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class AircraftRepositoryAsync : ARepositoryAsync<Aircraft>
{
    public AircraftRepositoryAsync(AircraftContext context) : base(context) { }
}