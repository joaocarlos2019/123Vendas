using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123Vendas.Domain
{
    public class VendaItem
    {
        public Produto produto { get; set; }

        public int QuantidadeVenda { get; set; }

        public double TotalDescontos { get; set; }

        public double ValorTotalItem { get; set; }

        public bool ItemCancelado { get; set; }





    }
}
