using AgenciaBancaria.Cliete;
using AgenciaBancaria.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Repository
{
    public class ClienteRepository
    {

        public static List<Cliente> clienteMaster = new List<Cliente>();

        public void AddCliente(Cliente cliente)
        {
            clienteMaster.Add(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return clienteMaster;
        }


        public void Atualizar(int ClienteId, Cliente cliente)
        {
            Cliente clienteAtualizar = clienteMaster.FirstOrDefault(p => p.Id == ClienteId);

            if (clienteAtualizar != null)
            {
                clienteAtualizar.Endereco = cliente.Endereco;

            }
        }

        public bool ClienteExiste(string nome)
        {
            return clienteMaster.Any(p => p.Nome == nome);
        }


        public void DeletarCliente(int clienteID)
        {
            Cliente removerCliente = clienteMaster.FirstOrDefault(cliente => cliente.Id == clienteID);

            if (removerCliente != null)
            {
       
                bool temSaldo = removerCliente.ContaBancaria.Saldo > 0;

                if (!temSaldo)
                {
                    clienteMaster.Remove(removerCliente);
                    Console.WriteLine();
                    Console.WriteLine("Cliente Deletado com sucesso");

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Não é possível deletar o cliente porque há saldo em sua conta bancária.");
                }
            }

        }
    }
}
