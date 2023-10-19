using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio.Entidades
{
    public class Usuarios
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime Nasimeno { get; set; }
        public DateTime Contato { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Observacoes { get; set; }
        public Usuarios(string nome, string telefone, string email, string endereco, DateTime nascimento)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Nasimeno = nascimento;
           
        }
    }
}
