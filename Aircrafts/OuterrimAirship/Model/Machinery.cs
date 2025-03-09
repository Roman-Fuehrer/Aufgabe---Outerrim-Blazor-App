using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OuterrimAirship.Model;

[Table("Machineries")]
public class Machinery
{
    #region Properties
    
    [Column("MachineryId"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Column("Label", TypeName = "varchar(45)")]
    public string Label { get; set; }
    
    [Column("Function", TypeName = "varchar(200)")]
    public string Function { get; set; }
    
    public string Type { get; set; }
    
    #endregion

    #region Relations
    
    [Required, Column("CompartmentId")]
    public int CompartmentId{ get; set; }
    
    public Compartment? Compartments { get; set; }

    #endregion
}