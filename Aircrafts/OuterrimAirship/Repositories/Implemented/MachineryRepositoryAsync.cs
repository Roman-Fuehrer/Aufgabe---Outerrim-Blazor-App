using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class MachineryRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<Machinery>(context);