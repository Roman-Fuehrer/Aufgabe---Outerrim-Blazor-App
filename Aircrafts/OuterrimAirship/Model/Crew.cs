using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Crews")]
public class Crew
{
    #region Properties

    [Required, Column("JoinedAt")]
    public DateTime JoinedAt { get; set; }

    #endregion

    #region Relations

    [Required, Column("SpacecraftId")]
    public int SpacecraftId { get; set; }
    
    public Spacecraft? Spacecraft { get; set; }

    
    [Required, Column("MercenaryId")]
    public int MercenaryId { get; set; }
    
    public Mercenary? Mercenary { get; set; }

    #endregion
}