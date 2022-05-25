using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco72C_17_Matheus
{
    public class Conta
    {
        // Criação dos atributos internos da classe
        private Int64 numero;
        private decimal saldo;
        private decimal limite;

        // Criação das propriedades da classe
        public Int64 Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Decimal Limite
        {
            get { return limite; }
            set { limite = value; }
        }
    }
}
