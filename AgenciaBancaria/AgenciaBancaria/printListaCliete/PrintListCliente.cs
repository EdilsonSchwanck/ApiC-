using AgenciaBancaria.Cliete;
using AgenciaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.printListaCliete
{
    public class PrintListCliente
    {
        public void PrintCliente()
        {
            Console.WriteLine();
            Console.WriteLine("Lista De Clientes:");
            Console.WriteLine("----------------");
            Console.WriteLine();

            for (int i = 0; i < ClienteRepository.clienteMaster.Count; i++)
            {
                Cliente cliente = ClienteRepository.clienteMaster[i];
                Console.WriteLine($"ID:{cliente.Id}| Nome:{cliente.Nome}| CPF:{cliente.Cpf}| Endereço: {cliente.Endereco}| ID da conta: {cliente.ContaBancaria.Id}" +
                  $"| Numero da conta: {cliente.ContaBancaria.Numero}| Saldo da Conta R$: {cliente.ContaBancaria.Saldo}");
            }


            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();


        }


    }
}
