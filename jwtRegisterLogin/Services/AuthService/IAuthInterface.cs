using jwtRegisterLogin.Dtos;
using jwtRegisterLogin.Models;

namespace jwtRegisterLogin.Services.AuthService
{
    public interface IAuthInterface
    {
        public Task<Response<UsuarioCriacaoDto>> Registrar(UsuarioCriacaoDto usuarioRegistro);
        public Task<Response<string>> Login(UsuarioLoginDto usuarioLogin);
    }
}
