using _123Vendas.Data;
using _123Vendas.Domain;
using _123Vendas.Service;
using MediatR;
using Moq;

namespace _123Vendas.TestApplication
{
    public class VendasRepositoryTest
    {
        [Fact]
        public async void VendasRepository_Adicionar_DeveRetornarTrue()
        {
           
            var vendasRepository = new VendaRepository();
            var _venda = FactoryVenda();
            var vendaAdicionada=await vendasRepository.AdicionarVenda(_venda);
            Assert.True(vendaAdicionada);
        }

        [Fact]
        public async void VendasRepository_Atualizar_DeveRetornarFalse()
        {

            var vendasRepository = new VendaRepository();
            var _venda = FactoryVendaAtualizar();
            var vendaAdicionada = await vendasRepository.AtualizarVenda(_venda);
            Assert.False(vendaAdicionada);
        }

        [Fact]
        public async void VendasRepository_Excluir_DeveRetornarTrue()
        {

            var vendasRepository = new VendaRepository();
            var _venda = FactoryVenda();
            var vendaAdicionada = await vendasRepository.AdicionarVenda(_venda);
            var excluirVenda = await vendasRepository.ExcluirVenda(_venda.NumeroDaVenda);
            Assert.True(excluirVenda);
        }

        [Fact]
        public async void VendasRepository_Excluir_DeveRetornarFalse()
        {

            var vendasRepository = new VendaRepository();
            var _venda = FactoryVenda();           
            var excluirVenda = await vendasRepository.ExcluirVenda(_venda.NumeroDaVenda);
            Assert.False(excluirVenda);
        }


        public Venda FactoryVenda()
        {
            var cliente = new Cliente() { CodigoCliente = 1, NomeCliente = "JOÃO CARLOS SILVA SANTOS" };
            var produto = new Produto() { CodigoBarra = "01234567890", CodigoProduto = 1, NomeProduto = "POLPA DE FRUTAS", ValorUnitario = 2.90 };
            var vendaItem=new VendaItem() {ItemCancelado=false,produto=produto,QuantidadeVenda=100,TotalDescontos=300,ValorTotalItem=1500};
            var Venda = new Venda() { Cliente = cliente, DataEfetuacaoVenda = DateTime.Now, NumeroDaVenda = 1, ValorTotalVenda = 1200, ItemVenda = new List<VendaItem>()};
            Venda.ItemVenda.Add(vendaItem);
            return Venda;

        }

        public Venda FactoryVendaAtualizar()
        {
            var cliente = new Cliente() { CodigoCliente = 1, NomeCliente = "JOÃO CARLOS SILVA SANTOS" };
            var produto = new Produto() { CodigoBarra = "01234567890", CodigoProduto = 1, NomeProduto = "POLPA DE FRUTAS", ValorUnitario = 2.90 };
            var vendaItem = new VendaItem() { ItemCancelado = false, produto = produto, QuantidadeVenda = 100, TotalDescontos = 300, ValorTotalItem = 1500 };
            var Venda = new Venda() { Cliente = cliente, DataEfetuacaoVenda = DateTime.Now, NumeroDaVenda = 1, ValorTotalVenda = 1200, ItemVenda = new List<VendaItem>() };
            Venda.ItemVenda.Add(vendaItem);
            return Venda;

        }
    }
}