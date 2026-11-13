using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vex.Models.Database;

public class Message
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ID { get; set; }
    [MaxLength(32)]
    public required string CreditNumber { get; set; }
    public required string Text { get; set; }
}
