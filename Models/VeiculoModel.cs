using ASPNETConcessionaria.Enums;
using ASPNETConcessionaria.Enums.VeiculosEnums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETConcessionaria.Models;

public class VeiculoModel
{
    [Key]
    public int VeiculoId { get; set; }
    [Required]
    public CarroceriaEnum Carroceria { get; set; }
    [Required]
    public MarcaEnum Marca { get; set; }
    [Required]
    public int Modelo { get; set; }
    [Required]
    public string Ano { get; set; }
    [Required]
    public string Quilometragem { get; set; }
    [Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(20,2)")]
    public decimal Preco { get; set; }
    [Required]
    public string Cidade { get; set; }
    [Required]
    public EstadosEnum Estado { get; set;}
    [Required]
    public string Placa { get; set; }
    public string Opcionais { get; set; }
    public string ImagemUrl { get; set; }
}
