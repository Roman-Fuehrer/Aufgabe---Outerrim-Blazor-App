using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Spacecrafts")]
public class Spacecraft
{
    #region Properties

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
    public int Id { get; init; }

    [Required, Column("Name", TypeName = "varchar(200)")]
    public string Name { get; set; }

    [Required, Column("Fuel")]
    public int Fuel { get; set; }

    [Required, Column("Speed")]
    public int Speed { get; set; }

    [Required, Column("Altitude")]
    public int Altitude { get; set; }

    #endregion

    #region Relations

    [Required, Column("SpacecraftSpecificationId")]
    public int SpacecraftSpecificationId { get; set; }
    
    public SpacecraftSpecification? SpacecraftSpecification { get; set; }
    
    public List<Compartment>? Compartments { get; set; }
    public List<Crew>? Crews { get; set; }

    #endregion
}