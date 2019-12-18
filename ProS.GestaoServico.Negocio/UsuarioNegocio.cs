using ProS.GestaoServico.Entidades.Model;
using ProS.GestaoServico.Repositorio;

namespace ProS.GestaoServico.Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioRepositorio usuarioRepositorio;

        public UsuarioNegocio(UsuarioRepositorio _usuarioRepositorio)
        {
            usuarioRepositorio = _usuarioRepositorio;
        }
        public UsuarioModel ObterUsuario(UsuarioModel usuario)
        {
            return usuarioRepositorio.ObterUsuario(usuario);
        }
    }
}
