namespace _123Vendas.Domain
{
    public class Venda
    {
        public int NumeroDaVenda { get; set; }

        public DateTime DataEfetuacaoVenda { get; set; }

        public double ValorTotalVenda { get; set; }

        public Cliente Cliente { get; set; }

        List<VendaItem> ItemVenda { get; set; }




    }
}
