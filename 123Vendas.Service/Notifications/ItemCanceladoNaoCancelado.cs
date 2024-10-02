using MediatR;

namespace _123Vendas.Service.Notifications
{
    public class ItemCanceladoNaoCancelado:INotification
    {
        public int NumeroVenda { get; set; }

        public int CodigoProduto { get; set; }

        public int CodigoItem { get; set; }

        public bool Status { get; set; }
    }
}
