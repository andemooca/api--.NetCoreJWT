using System.Threading.Tasks;
using api__ProS.GestaoServico.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProS.GestaoServico.Entidades;
using ProS.GestaoServico.Entidades.Model;
using ProS.GestaoServico.Negocio;
using ProS.GestaoServico.Repositorio;

namespace api__ProS.GestaoServico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        private ProSLogger logger = new ProSLogger();
        public UsuarioNegocio usuarioNegocio { get; set; }

        public OAuthController(UsuarioNegocio _usuarioNegocio)
        {
            usuarioNegocio = _usuarioNegocio;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody]Usuario model)
        {
            try
            {
                if (model.Login != null && model.Senha != null)
                {

                    UsuarioModel usuario = usuarioNegocio.ObterUsuario(new UsuarioModel() { Login = model.Login, Senha = model.Senha });

                    if (usuario == null)
                    {
                        logger.Info("Login",
                        string.Format("Usuario{0} - Senha {0}",
                        model.Login != null ? model.Login : "",
                        model.Senha != null ? model.Senha : ""));

                        return NotFound(new { message = "Usuário e/ou senha inválidos" });
                    }

                    var resultToken = TokenService.GenerateToken(usuario);
                    usuario.Senha = string.Empty;

                    return new { user = usuario, token = resultToken };
                }
                else
                {
                    logger.Info("Login",
                        string.Format("Usuario{0} - Senha {0}",
                        model.Login != null ? model.Login : "",
                        model.Senha != null ? model.Senha : ""));

                    return NotFound(new { message = "Usuário e/ou senha inválidos" });
                }
            }
            catch (System.Exception ex)
            {
                logger.Error("Login", "Erro Critico Login", ex);
                throw;
            }
        }
    }
}