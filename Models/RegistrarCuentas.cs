

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bancaweb.Models
{
    public class RegistrarCuentas{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    [Required]
    public string? NombreTitular { get; set; }

    [Required]
    public string? TipoCuenta { get; set; }

    [Required]
    public decimal SaldoInicial { get; set; } 

    [Required]
    public string? Email { get; set; }
    }
}