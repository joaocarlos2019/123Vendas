using _123Vendas.Domain;

namespace _123Vendas.Service
{
    public interface IVendasService
    {
        public Task<Venda> AlterarVenda(Venda venda);
        public Task<bool> ExcluirVenda(int id);
        public Task<Venda> Adicionar(Venda venda);
        public Task<Venda> ObterPorId(int id);

    }
}
