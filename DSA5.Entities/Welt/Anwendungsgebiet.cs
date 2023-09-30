using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Welt;

[Table("Anwendungsgebiet")]
public class Anwendungsgebiet
{
    public string Name { get; set; } = null!;
    
}