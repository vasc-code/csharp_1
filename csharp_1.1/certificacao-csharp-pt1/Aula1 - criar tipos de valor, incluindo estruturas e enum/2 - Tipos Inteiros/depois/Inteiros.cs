using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S'; //Sytem.char

            byte nivelDeAzul = 0xff;  //=255 em decimal
            //nivelDeAzul = -3;
            short passageirosVoo = 230; //System.Int16
            passageirosVoo = -7;
            int populacao = 1500; //System.Int32
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; // +/- 207 milhões - System.Int64

            sbyte nivelDeBrilho = -127; //System.Sbyte
            ushort passageirosNavio = 230; //System.UInt16

            uint estoque = 1500; //System.UInt32
            ulong populacaoDoMundo = 7_000_000_000; //7bilhoes - System.Ulong


            Console.WriteLine(resposta);

            Console.WriteLine(nivelDeAzul);
            Console.WriteLine(passageirosVoo);
            Console.WriteLine(populacao);
            Console.WriteLine(populacaoDoBrasil);
            Console.WriteLine(nivelDeBrilho);
            Console.WriteLine(passageirosNavio);
            Console.WriteLine(estoque);
            Console.WriteLine(populacaoDoMundo);
        }
    }
}
