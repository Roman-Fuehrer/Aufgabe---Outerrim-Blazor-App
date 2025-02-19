using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Compartments")]
public class Compartment
{
    #region Properties

        [Column("Compartment_Id")]
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

    #endregion
    
    #region Relations
    [Required, Column("Aircraft_Id")]
    public int AircraftId { get; set; }
    
    public Aircraft? Aircraft { get; set; }
    
    #endregion
    
    
    
    
}