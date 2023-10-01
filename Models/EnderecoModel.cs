using ASPNETConcessionaria.Enums;
using ASPNETConcessionaria.Models.FuncionariosModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ASPNETConcessionaria.Models;

public class EnderecoModel
{
    [Key]
    public int EnderecoId {  get; set; }
    [Required]
    public string Logradouro { get; set; }
    [Required]
    public string Bairro { get; set; }
    [Required]
    public string Cidade { get; set; }
    [Required]
    public EstadosEnum Estado { get; set; }
    [Required]
    public string CEP { get; set; }

}
