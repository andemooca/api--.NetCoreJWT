using System;

namespace ProS.GestaoServico.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Hash { get; set; }
        public int IdPerfil { get; set; }
        public Perfil Perfil{ get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public bool isAlterarSenha { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
    }
}
