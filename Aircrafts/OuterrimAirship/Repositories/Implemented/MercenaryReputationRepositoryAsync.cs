using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class MercenaryReputationRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<MercenaryReputation>(context);