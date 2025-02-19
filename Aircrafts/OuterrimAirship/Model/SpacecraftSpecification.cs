using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("SpacecraftSpecifications")]
public class SpacecraftSpecification
{
    #region Properties

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
    public int Id { get; set; }

    [Required, Column("SpecificationCode", TypeName = "varchar(45)")]
    public required string SpecificationCode { get; set; }

    [Required, Column("Structure")]
    public int Structure { get; set; }

    [Required, Column("FuelTankCapacity")]
    public int FuelTankCapacity { get; set; }

    [Required, Column("MinSpeed")]
    public int MinSpeed { get; set; }

    [Required, Column("MaxSpeed")]
    public int MaxSpeed { get; set; }

    [Required, Column("MaxAltitude")]
    public int MaxAltitude { get; set; }

    #endregion

    #region Relations

    public List<Spacecraft>? Spacecrafts { get; set; }

    #endregion
}