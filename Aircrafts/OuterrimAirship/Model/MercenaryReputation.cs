using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("MercenaryReputations")]
public class MercenaryReputation
{
    #region Properties

    [Required, Column("ReputationChange", TypeName = "varchar(45)")]
    public required string ReputationChange { get; set; }

    #endregion

    #region Relations

    [Required, Column("MercenaryId")]
    public int MercenaryId { get; set; }
    
    public Mercenary? Mercenary { get; set; }

    
    [Required, Column("CrimeSyndicateId")]
    public int CrimeSyndicateId { get; set; }
    
    public CrimeSyndicate? CrimeSyndicate { get; set; }

    #endregion
}