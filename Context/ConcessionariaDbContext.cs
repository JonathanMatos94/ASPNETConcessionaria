using ASPNETConcessionaria.Models;
using ASPNETConcessionaria.Models.FuncionariosModel;
using ASPNETConcessionaria.Models.NegociacoesModels;
using Microsoft.EntityFrameworkCore;

namespace ASPNETConcessionaria.Context
{
    public class ConcessionariaDbContext : DbContext
    {
        public ConcessionariaDbContext(DbContextOptions<ConcessionariaDbContext> options) :base(options)
        {
            
        }
        public DbSet<VeiculoModel> Veiculos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        public DbSet<NegociacaoModel> Negociacoes { get; set; }

    }
}
