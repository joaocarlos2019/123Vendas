using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123Vendas.Domain
{
    public class Produto
    {
        public int CodigoProduto { get; set; }

        public string NomeProduto { get; set; }

        public string CodigoBarra { get; set; }

        public double ValorUnitario { get; set; }
    }
}
