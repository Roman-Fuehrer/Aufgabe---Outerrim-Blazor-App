using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class CompartmentRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<Compartment>(context);