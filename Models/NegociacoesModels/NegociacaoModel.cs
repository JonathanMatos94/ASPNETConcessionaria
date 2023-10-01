using ASPNETConcessionaria.Enums;
using ASPNETConcessionaria.Models.NegociacoesModels.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETConcessionaria.Models.NegociacoesModels;

public class NegociacaoModel : INegociacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NegociacaoId { get; set; }
    [Required]
    public NegociacaoEnum Negociacao { get; set; }
    [Required]
    public ClienteModel Cliente { get; set; }
    [Required]
    public VeiculoModel Veiculo { get; set; }
    [Required]
    [Column(TypeName = "decimal(20,2)")]
    public decimal SaldoTotal { get; set; }
    [Required]
    [Column(TypeName = "decimal(20,2)")]
    public decimal SaldoVendas { get; set; }
    [Required]
    [Column(TypeName = "decimal(20,2)")]
    public decimal SaldoCompras { get; set; }
    [Required]
    public DateTime DataNegociacao { get; set; }

    public void Vender(ClienteModel cliente, VeiculoModel veiculo)
    {
        throw new NotImplementedException();
    }

    public void Comprar(ClienteModel cliente, VeiculoModel veiculo)
    {
        throw new NotImplementedException();
    }
}
