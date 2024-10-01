namespace _123Vendas.ViewModels
{
    public class VendaItemViewModel
    {
        public ProdutoViewModel produto { get; set; }

        public int QuantidadeVenda { get; set; }

        public double TotalDescontos { get; set; }

        public double ValorTotalItem { get; set; }

        public bool ItemCancelado { get; set; }

    }
}
