using System;

namespace Cobranca.Domain
{
    public class Cliente
    {
        public Cliente(int id, string nome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
        } 

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}