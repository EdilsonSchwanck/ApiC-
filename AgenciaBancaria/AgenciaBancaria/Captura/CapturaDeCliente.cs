using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Captura
{
    public class CapturaDeCliente
    {

        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        public string Cpf { get; private set; }


        public void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu Nome!");
            this.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite seu Endereço!");
            this.Endereco = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite seu CPF!");
            this.Cpf = Console.ReadLine();
        }

    }
}
