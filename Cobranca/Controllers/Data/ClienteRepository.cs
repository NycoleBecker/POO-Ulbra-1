using System;
using System.Collections.Generic;
using Cobranca.Domain;

namespace clientesCobrancas.Data
{
    public class ClienteRepository
    {
        private List<Cliente> listaDeClientes = new List<Cliente>();

        public List<Cliente> GetAll()
        {
            return listaDeClientes;
        } 

        public Cliente GetById(int idCliente)
        {
            return listaDeClientes.Find(p => p.Id == idCliente); 
        }

        public string GetByNome(string nomeCliente)
        {
            int i = 0;
            foreach (var item in listaDeClientes)
            {
                if(nomeCliente.Equals(item.Nome)){
                    i++;
                }
            }

            if(i > 1)
            {
                Console.WriteLine($"Foram encontrados {i} clientes cadastrados com o nome '{nomeCliente}' na lista de clientes.\n");
                return "Há mais de um cliente com esse nome";
            }
            else if(i == 1)
            {
                Console.WriteLine($"{nomeCliente} está cadastrado na lista de clientes.");
                return "Há 1 cliente com esse nome";
            }
            else
            {
                Console.WriteLine($"Não foi encontrado nenhum cliente com o nome {nomeCliente} na lista.");
                return "Não há cliente com o nome digitado";
            }
        }

        public void Update(Cliente cliente)
        {
            var clienteEditado = GetById(cliente.Id);

            clienteEditado.Nome = cliente.Nome;
            clienteEditado.Telefone = cliente.Telefone;
        }

        public void Save(Cliente cliente)
        {
            listaDeClientes.Add(cliente);
        }

        public void Delete(Cliente cliente)
        {
            listaDeClientes.Remove(cliente);
        }

    }
}