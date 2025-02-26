using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Mercenaries")]
public class Mercenary
{
    #region Properties

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Id")]
    public int Id { get; init; }

    [Column("FirstName", TypeName = "varchar(45)")]
    public string? FirstName { get; set; }

    [Column("LastName", TypeName = "varchar(45)")]
    public string? LastName { get; set; }

    [Column("BodySkills")]
    public int BodySkills { get; set; }

    [Column("CombatSkills")]
    public int CombatSkills { get; set; }

    #endregion

    #region Relations

    public List<MercenaryReputation>? MercenaryReputations { get; set; }

    public List<Crew>? Crews { get; set; }

    #endregion
}