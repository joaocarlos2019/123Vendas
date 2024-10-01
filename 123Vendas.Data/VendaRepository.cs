using _123Vendas.Data.Interfaces;
using _123Vendas.Domain;
using System.Reflection.Metadata.Ecma335;

namespace _123Vendas.Data
{
    public class VendaRepository : IVendaRepository
    {
        private List<Venda> _listVenda;
        public VendaRepository()
        {
            _listVenda = new List<Venda>();
        }

        public async Task<bool> AdicionarVenda(Venda venda)
        {
            _listVenda.Add(venda);
            return true;
        }

        public async Task<bool> AtualizarVenda(Venda venda)
        {
            var updated = false;
            var NumberIndex = _listVenda.FindIndex(x => x.NumeroDaVenda == venda.NumeroDaVenda);
            if (NumberIndex > 0)
            {
                _listVenda.RemoveAt(NumberIndex);
                _listVenda.Add(venda);
                updated = true;
            }
            return updated;
        }

        public async Task<bool> ExcluirVenda(Venda venda)
        {
            var removed = false;
            var NumberIndex = _listVenda.FindIndex(x => x.NumeroDaVenda == venda.NumeroDaVenda);
            if (NumberIndex > 0)
            {
                _listVenda.RemoveAt(NumberIndex);               
                removed = true;
            }
            return removed;
        }

        public async Task<Venda> ObterVenda(int id)
        {
            return  _listVenda.FirstOrDefault(x => x.NumeroDaVenda == id);
        }
    }
}
