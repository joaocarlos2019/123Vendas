using MediatR;

namespace _123Vendas.Service.Notifications
{
    public class CompraAlteradaNotification:INotification
    {
        public int NumeroVenda { get; set; }

        public double TotalVenda { get; set; }
    }
}
