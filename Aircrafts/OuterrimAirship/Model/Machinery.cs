using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OuterrimAirship.Model;

[Table("Machineries")]
public class Machinery
{
    #region Properties
    
    [Column("Machinery_Id"),Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required,Column("Lable")]
    public string Label { get; set; }
    
    [Required, Column("Funktion")]
    public string Text { get; set; }
    
    #endregion
    
    
}