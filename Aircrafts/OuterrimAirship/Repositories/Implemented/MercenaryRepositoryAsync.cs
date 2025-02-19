using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class MercenaryRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<Mercenary>(context);