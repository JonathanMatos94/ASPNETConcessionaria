using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ASPNETConcessionaria.Models;

public class ClienteModel
{
    [Key]
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public EnderecoModel Endereco { get; set; }
    public int EnderecoId { get; set; }
}
