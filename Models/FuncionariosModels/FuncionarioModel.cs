using ASPNETConcessionaria.Enums;
using ASPNETConcessionaria.Models.FuncionariosModel.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETConcessionaria.Models.FuncionariosModel;

public class FuncionarioModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FuncionarioId { get; set; }
    [Required]
    public bool Ativo = true;
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Telefone { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Senha { get; set; }
    [Required]
    [Column(TypeName = "decimal(20,2)")]
    public decimal Salario { get; set; }
    [Required]
    public DateTime DataContracao { get; set; }
    [Required]
    public DateTime DataUltimoAumento { get; set; }
    public string ImagemUrl { get; set; }

}
