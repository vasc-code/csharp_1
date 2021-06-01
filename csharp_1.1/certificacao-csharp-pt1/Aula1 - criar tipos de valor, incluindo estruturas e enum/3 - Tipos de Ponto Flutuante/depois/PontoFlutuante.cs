using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class PontoFlutuante
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            //int massa = 6_000000_000000_000000_0000000;
            //long massa = 6_000000_000000_000000_0000000;
            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");
        }
    }
}
