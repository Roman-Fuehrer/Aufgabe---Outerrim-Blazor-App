using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class SpacecraftSpecificationRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<SpacecraftSpecification>(context);