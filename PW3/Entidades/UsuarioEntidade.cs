using Microsoft.AspNetCore.Mvc;

namespace PW3.Entidades
{
    public class UsuarioEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

   
    }
}
