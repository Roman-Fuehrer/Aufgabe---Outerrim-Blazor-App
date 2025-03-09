using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;

namespace OuterrimAirship.Repositories.Implemented;

public class MachineryRepositoryAsync : ARepositoryAsync<Machinery>
{
    public MachineryRepositoryAsync(SpacecraftContext context) : base(context)
    {
        
    }
    public async Task<List<Machinery>> GetWeaponsAsync()
    {
        var machinery = await base.ReadAllAsync();
        return machinery.Where(a => a.Type == "Weapon").ToList(); 
    }
    
}