using ASPNETConcessionaria.Models.FuncionariosModel.Interfaces;

namespace ASPNETConcessionaria.Models.FuncionariosModel;

public class GerenteModel : FuncionarioModel, IFuncionario
{
    public void AumentoSalarial()
    {
        Salario *= 1.15m;
    }

    public void BonificacaoAnual()
    {
        throw new NotImplementedException();
    }

    public void BonusTempoDeServico()
    {
        DateTime dataAtual = DateTime.Now;
        TimeSpan diferenca = dataAtual - DataUltimoAumento;

        if (diferenca.TotalDays > 365)
        {
            Salario *= 1.1m;
        }
    }

    public bool DesligarFuncionario()
    {
        return Ativo = false; ;
    }
}
