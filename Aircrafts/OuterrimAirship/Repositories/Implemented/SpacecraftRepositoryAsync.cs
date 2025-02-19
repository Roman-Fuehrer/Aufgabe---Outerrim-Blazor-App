using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class SpacecraftRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<Spacecraft>(context);