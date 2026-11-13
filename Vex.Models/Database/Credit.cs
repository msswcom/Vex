using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vex.Models.Database;

public class Credit
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required long ID { get; set; }
    [MaxLength(32)]
    public required string Number { get; set; }
    [MaxLength(64)]
    public required string CustomerName { get; set; }
    [MaxLength(16)]
    public required string CustomerPhone { get; set; }
    public required decimal Amount { get; set; }
    public required DateTime DueDate { get; set; }

    public static readonly List<string> Properties =[
        nameof(Number),
        nameof(CustomerName),
        nameof(CustomerPhone),
        nameof(Amount),
        nameof(DueDate),
        ];

    public string? Property(string property)
    {
        return property switch
        {
            nameof(Number) => Number,
            nameof(CustomerName) => CustomerName,
            nameof(CustomerPhone) => CustomerPhone,
            nameof(Amount) => Amount.ToString(),
            nameof(DueDate) => DueDate.ToString("d"),
            _ => null,
        };
    }
}
