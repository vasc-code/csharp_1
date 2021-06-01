using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("OBJECT com valor primitivo");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine(meuObjeto);
            Console.WriteLine(meuObjeto.GetType());

            Console.WriteLine();
            Console.WriteLine("OBJECT com referência de objeto");
            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto;
            Console.WriteLine(classRef);
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
