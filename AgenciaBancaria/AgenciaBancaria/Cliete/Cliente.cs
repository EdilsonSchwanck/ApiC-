using AgenciaBancaria.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Cliete
{
    public class Cliente
    {

        private static int generateNumber = 1;
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Endereco { get; set; }

        public string Cpf { get; private set; }


        public ContaBancaria ContaBancaria { get; set; }


       

        public Cliente(string nome, string endereco, string cpf, ContaBancaria conta)
        {
            this.Id = generateNumber;
            generateNumber++;

            this.Nome = nome;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.ContaBancaria = conta;
            
        }

    }
}

