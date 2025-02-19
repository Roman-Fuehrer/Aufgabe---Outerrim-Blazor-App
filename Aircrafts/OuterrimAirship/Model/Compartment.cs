using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Compartments")]
public class Compartment
{
    [Column("Compartment_Id")]
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public Machinery Machinery { get; set; }
}