using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenderProdutos
{
    public class Venda
    {
        public int Item { get; set; }
        public String NomeProduto { get; set; }
        public int Und { get; set; }
        public float ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public int Desconto { get; set; }
        public float ValorTotal { get; set; }
        
    }
}
