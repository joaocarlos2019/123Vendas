using MediatR;

namespace _123Vendas.Service.Notifications
{
    public class CompraCanceladaNotification:INotification
    {
        public int NumeroVenda { get; set; }
        
    }
}
