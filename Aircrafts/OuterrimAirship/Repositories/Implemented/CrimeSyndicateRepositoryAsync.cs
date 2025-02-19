using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class CrimeSyndicateRepositoryAsync(SpacecraftContext context) : ARepositoryAsync<CrimeSyndicate>(context);