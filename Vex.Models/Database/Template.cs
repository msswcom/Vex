using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vex.Models.Database;

public class Template
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required long ID { get; set; }
    [MaxLength(32)]
    public required string Name { get; set; }
    [MaxLength(256)]
    public required string Text { get; set; }
}
