using _123Vendas.Data.Interfaces;
using _123Vendas.Domain;
using _123Vendas.Service.Notifications;
using MediatR;


namespace _123Vendas.Service
{
    public class VendasService : IVendasService
    {        
        private readonly IVendaRepository _vendaRepository;
        private readonly IMediator _mediator;

        public VendasService(IVendaRepository vendaRepository, IMediator mediator)
        {            
            _vendaRepository = vendaRepository;
            _mediator = mediator;
        }


        public async Task<Venda> Adicionar(Venda venda)
        {
            var VendaFoiAdicionada=await _vendaRepository.AdicionarVenda(venda);
            if (VendaFoiAdicionada)
            {
                  await _mediator.Publish(new CompraCriadaNotification
                    {
                        NumeroVenda = venda.NumeroDaVenda,
                        ValorTotal = venda.ValorTotalVenda
                    });
                
            }
            return venda;
        }

        public async Task<Venda> AlterarVenda(Venda venda)
        {
            var vendaFoiAlterada = await _vendaRepository.AtualizarVenda(venda);
            if (vendaFoiAlterada)
            {
                await _mediator.Publish(new CompraAlteradaNotification
                {
                    NumeroVenda = venda.NumeroDaVenda,
                    TotalVenda = venda.ValorTotalVenda
                });
            }
            var vendaAlterada = await _vendaRepository.ObterVenda(venda.NumeroDaVenda);
            return vendaAlterada;

        }

        public async Task<bool> ExcluirVenda(int id)
        {
            var vendaFoiRemovida = await _vendaRepository.ExcluirVenda(id);
            if(vendaFoiRemovida)
            {
                await _mediator.Publish(new CompraCanceladaNotification
                {
                    NumeroVenda = id,
                    
                });
            }
            return vendaFoiRemovida;
        }

        public async Task<Venda> ObterPorId(int id)
        {
            return await _vendaRepository.ObterVenda(id);
        }
    }
}
