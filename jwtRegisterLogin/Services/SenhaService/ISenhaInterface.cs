using jwtRegisterLogin.Models;

namespace jwtRegisterLogin.Services.SenhaService
{
    public interface ISenhaInterface
    {
        public void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
        public bool VerificaSenhaHash(string senha, byte[] senhaHash, byte[] senhaSalt);
        public string CriarToken(UsuarioModel usuario);
    }
}
