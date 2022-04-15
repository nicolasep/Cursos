using Microsoft.AspNetCore.Identity;
using Servicios.api.Seguridad.Core.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.api.Seguridad.Core.Persistance
{
    public class SeguridadData
    {
        public static async Task InsertarUsuario(SeguridadContexto contexto, UserManager<Usuario> usuarioManager)
        {
            if(!usuarioManager.Users.Any())
            {
                var usuario = new Usuario{
                    Nombre = "nicolas",
                    Apellido = "perez",
                    Direccion = "Av. La Madrid 369",
                    UserName = "VaxiDrez",
                    Email = "nico@gmail.com"
                };
                await usuarioManager.CreateAsync(usuario, "Password123$");
            }
        }
    }
}
