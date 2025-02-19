using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Compartments")]
public class Compartment
{
    #region Properties

        [Column("CompartmentId")]
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

    #endregion
    
    #region Relations
    
    [Required, Column("SpacecraftId")]
    public int SpacecraftId { get; set; }
    
    public Spacecraft? Spacecraft { get; set; }
    
    public List<Machinery>? Machineries { get; set; }
    
    #endregion
    
}