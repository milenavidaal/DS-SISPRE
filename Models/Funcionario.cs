using System;
using System.Collections.Generic;
using System.Text;

namespace DS_SISPRE.Models
{
    class Funcionario
    {
       public int Id { get; set; }

        public string Nome { get; set; }
        public string RG { get; set; }

        public string CPF { get; set; }

        public string Name { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }
        public string Funcao { get; set; }

        public string Salario { get; set; }
    }
}
