using System;
using System.Collections.Generic;
using System.Text;

namespace ProS.GestaoServico.Entidades.Model
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdPerfil { get; set; }
        public string NomePerfil { get; set; }
        public bool PerfilAtivo { get; set; }
        public bool IsAdmin { get; set; }
    }
}
