using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("CrimeSyndicates")]
public class CrimeSyndicate
{
    #region Properties

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
    public int Id { get; init; }

    [Required, Column("Name", TypeName = "varchar(120)")]
    public required string Name { get; set; }

    [Required, Column("Location", TypeName = "varchar(200)")]
    public required string Location { get; set; }

    #endregion

    #region Relations

    public List<MercenaryReputation>? MercenaryReputations { get; set; }

    #endregion
}