using _123Vendas.Domain;

namespace _123Vendas.Data.Interfaces
{
    public interface IVendaRepository
    {
        Task<Venda> ObterVenda(int id);

        Task<bool> AdicionarVenda(Venda venda);

        Task<bool> AtualizarVenda(Venda venda);

        Task<bool> ExcluirVenda(Venda venda);
    }
}
