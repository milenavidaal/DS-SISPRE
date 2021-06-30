using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoTotal
{
    public class Orcamento
    {
        public int CodigoProduto { get; set; }
        public String NomeProduto { get; set; }
        public int ValorProduto { get; set; }
        public int Quantidade { get; set; }
        public int ValorImposto { get; set; }
        public String Distribuido { get; set; }
        public String Origem { get; set; }
        public float ValorTotalImp { get; set; }
        public float ValorCompra { get; set; }

    }
}
