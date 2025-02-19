using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class CompartmentRepositoryAsync : ARepositoryAsync<Compartment>
{
    public CompartmentRepositoryAsync(SpacecraftContext context) : base(context) { }
}