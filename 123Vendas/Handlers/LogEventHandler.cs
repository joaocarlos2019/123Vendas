using _123Vendas.Service.Handlers;
using _123Vendas.Service.Notifications;
using MediatR;
using Serilog;
namespace _123Vendas.Service.Handlers
{
    public class LogEventHandler : INotificationHandler<CompraCriadaNotification>,
                                   INotificationHandler<CompraCanceladaNotification>,
                                   INotificationHandler<CompraAlteradaNotification>,
                                   INotificationHandler<ItemCanceladoNaoCancelado>

    {
        public Task Handle(CompraCriadaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Log.Information("Compra criada Numero: " + notification.NumeroVenda + " Valor Total:" + notification.ValorTotal);
            });
        }

        public Task Handle(CompraCanceladaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Log.Information("Compra Cancelada Numero: " + notification.NumeroVenda );
            });
        }

        public Task Handle(CompraAlteradaNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Log.Information("Compra Alterada Numero: " + notification.NumeroVenda + " Valor Total:" + notification.TotalVenda);
            });
        }

        public Task Handle(ItemCanceladoNaoCancelado notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Log.Information("Compra Com Item Cancelado Numero: " + notification.NumeroVenda + " Codigo Item:" + notification.CodigoItem + " Codigo Produto:" + notification.CodigoProduto + " Alterado Para :" + notification.Status);
            });
        }
    }
}
