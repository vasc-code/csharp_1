using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            //int massa = 6_000000_000000_000000_0000000;
            //long massa = 6_000000_000000_000000_0000000;
            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            float massaDaTerra = 5.9736e24f;
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            float numeroPi= 3.14159f;
            Console.WriteLine(numeroPi);

            //float numeroMuitoMaior = 6e100f;
            double numeroMuitoMaior = 6e100;

            Console.WriteLine();
            int x = 3;
            short y = 5;

            var resultado = x * y;
            Console.WriteLine(resultado);
            Console.WriteLine(resultado.GetType());

            float z = 4.5f;
            var resultado2 = (x * y) / z;
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado2.GetType());

        }
    }
}
