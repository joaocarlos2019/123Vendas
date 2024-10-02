using MediatR;

namespace _123Vendas.Service.Notifications
{
    public class CompraCriadaNotification:INotification
    {
        public int NumeroVenda { get; set; }

        public double ValorTotal { get; set; }
    }
}
