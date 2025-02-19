using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class CrewRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<Crew>(context);