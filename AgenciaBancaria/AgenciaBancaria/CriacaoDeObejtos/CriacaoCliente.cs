using AgenciaBancaria.Captura;
using AgenciaBancaria.Cliete;
using AgenciaBancaria.Contas;
using AgenciaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.CriacaoDeObejtos
{
    public class CriacaoCliente
    {

        public void CiracaoCliente()
        {
 
            CapturaDeCliente capturaCliente = new CapturaDeCliente();
            capturaCliente.Captura();

     
            Cliente cliente = new Cliente(capturaCliente.Nome, capturaCliente.Endereco, capturaCliente.Cpf, null);

      
            CapturaContaBancaria capturaConta = new CapturaContaBancaria();
            capturaConta.capturaConta();

            ContaBancaria contaBancaria = new ContaBancaria(capturaConta.Numero, capturaConta.Saldo) { Cliente = cliente };
            new ContaBancariaRepository().AddContaBancaria(contaBancaria);

         
            cliente.ContaBancaria = contaBancaria;

            ClienteRepository repository = new ClienteRepository();
            repository.AddCliente(cliente);

            Console.WriteLine();
            Console.WriteLine("Cliente criado com sucesso. Nome do cliente: " + cliente.Nome);
            Console.WriteLine();
        }

       
   



    }
}
