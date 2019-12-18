using ProS.GestaoServico.Entidades;
using ProS.GestaoServico.Entidades.Model;
using System.Linq;

namespace ProS.GestaoServico.Repositorio
{
    public class UsuarioRepositorio 
    {
        public RepositorioBase<Usuario> repositorioBase { get; set; }

        public UsuarioRepositorio(RepositorioBase<Usuario> _repositorioBase)
        {
            repositorioBase = _repositorioBase;
        }

        public UsuarioModel ObterUsuario(UsuarioModel usuario)
        {
            UsuarioModel usuarioModel = null;

            usuarioModel = (from u in repositorioBase.Select()
                            where u.Login == usuario.Login
                            && u.Senha == usuario.Senha
                            select new UsuarioModel()
                            {
                                IdUsuario = u.IdUsuario,
                                NomeUsuario = u.Nome,
                                IdPerfil = u.IdPerfil,
                                Login = u.Login,
                                Senha = u.Senha,
                                NomePerfil = u.Perfil.Nome,
                                PerfilAtivo = u.Perfil.Ativo,
                                IsAdmin = u.Perfil.IsAdmin
                            }).FirstOrDefault();
        
            return usuarioModel;
        }
    }
}
