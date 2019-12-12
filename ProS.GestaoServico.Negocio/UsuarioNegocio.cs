using ProS.GestaoServico.Entidades;
using ProS.GestaoServico.Entidades.Model;
using ProS.GestaoServico.Repositorio;

namespace ProS.GestaoServico.Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioRepositorio usuarioRepositorio;

        public UsuarioNegocio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public UsuarioModel ObterUsuario(UsuarioModel usuario)
        {
            return usuarioRepositorio.ObterUsuario(new Usuario() { IdUsuario = usuario.IdUsuario });
        }
    }
}
