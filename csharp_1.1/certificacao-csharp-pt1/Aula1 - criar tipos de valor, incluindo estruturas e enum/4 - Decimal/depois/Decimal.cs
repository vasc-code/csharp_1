using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProd1 = 10;
            double valorProd2 = 20;
            double subtotal = 30;

            Console.WriteLine((valorProd1+valorProd2) == subtotal);

            valorProd1 = 10.10;
            valorProd2 = 20.20;
            subtotal = 30.30;
            Console.WriteLine((valorProd1 + valorProd2) == subtotal);

            Console.WriteLine(valorProd1+valorProd2);

            Console.WriteLine((valorProd1 + valorProd2) == 30.299999999999997);

            decimal materiaPrima = 10.1m;
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine((materiaPrima+maoDeObra) == custo);

        }
    }
}
