using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 20;
            int copiaIdade = idade;

            Console.WriteLine(idade);

            idade = 21;
            Console.WriteLine(idade);
            Console.WriteLine(copiaIdade);

            var cliente1 = new Cliente("Rafael", 20);
            var cliente2 = cliente1;

            Console.WriteLine();
            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);

            cliente1.Nome = "José da Silva";

            Console.WriteLine();
            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);
        }
    }

    class Cliente
    {
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
