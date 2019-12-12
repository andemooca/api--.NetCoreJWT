using ProS.GestaoServico.Entidades;
using ProS.GestaoServico.Entidades.Model;
using System.Linq;

namespace ProS.GestaoServico.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioModel ObterUsuario(Usuario usuario)
        {
            UsuarioModel usuarioModel = null;

            using (var repositorio = new RepositorioBase<Usuario>())
            {
                var usu = repositorio.Select(usuario.IdUsuario);
                //usuarioModel = (from u in repositorio.Select()
                //                where u.IdUsuario == usuario.IdUsuario
                //                select new UsuarioModel()
                //                {
                //                    IdUsuario = u.IdUsuario,
                //                    NomeUsuario = u.Nome,
                //                    IdPerfil = u.IdPerfil,
                //                    Login = u.Login,
                //                    Senha = u.Senha,
                //                    NomePerfil = u.Perfil.Nome,
                //                    PerfilAtivo = u.Perfil.Ativo,
                //                    IsAdmin = u.Perfil.IsAdmin
                //                }).FirstOrDefault();
            }
            return usuarioModel;
        }
    }
}
