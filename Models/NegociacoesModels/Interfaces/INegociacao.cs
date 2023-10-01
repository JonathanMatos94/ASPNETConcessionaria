namespace ASPNETConcessionaria.Models.NegociacoesModels.Interfaces;

public interface INegociacao
{
    public void Vender(ClienteModel cliente, VeiculoModel veiculo);
    public void Comprar(ClienteModel cliente, VeiculoModel veiculo);
}
