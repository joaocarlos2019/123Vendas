namespace _123Vendas.ViewModels
{
    public class VendaViewModel
    {
        public int NumeroDaVenda { get; set; }

        public DateTime DataEfetuacaoVenda { get; set; }

        public double ValorTotalVenda { get; set; }

        public ClienteViewModel Cliente { get; set; }

        public List<VendaItemViewModel> ItemVenda { get; set; }
    }
}
