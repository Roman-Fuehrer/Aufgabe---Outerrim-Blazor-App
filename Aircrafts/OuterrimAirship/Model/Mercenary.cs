using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Mercenaries")]
public class Mercenary
{
    #region Properties

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
    public int Id { get; init; }

    [Required, Column("FirstName", TypeName = "varchar(45)")]
    public required string FirstName { get; set; }

    [Required, Column("LastName", TypeName = "varchar(45)")]
    public required string LastName { get; set; }

    [Required, Column("BodySkills")]
    public int BodySkills { get; set; }

    [Required, Column("CombatSkills")]
    public int CombatSkills { get; set; }

    #endregion

    #region Relations

    public List<MercenaryReputation>? MercenaryReputations { get; set; }

    #endregion
}