using System;
using System.Collections.Generic;

namespace ProS.GestaoServico.Entidades
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
