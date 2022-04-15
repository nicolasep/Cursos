using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Servicios.api.Seguridad.Core.JwtLogic
{
    public class UsuarioSesion : IUsuarioSesion
    {
        private readonly IHttpContextAccessor _iHttpContextAccesor;

        public UsuarioSesion(IHttpContextAccessor iHttpContextAccesor)
        {
            _iHttpContextAccesor = iHttpContextAccesor;
        }
        public string GetUsuarioSesion()
        {
            var userName = _iHttpContextAccesor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == "username")?.Value;
            return userName;
        }
    }
}
