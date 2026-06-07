using CaixaIntegrador.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public static class ServicoDeRecuperacao
    {
        private const int ExpiracaoMinutos = 15;

        public static async Task<bool> SolicitarRecuperacaoAsync(string email)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios
                .FirstOrDefault(u => u.Email == email.Trim().ToLower());

            if (usuario == null) return false;

            string codigo = GerarCodigo6Digitos();

            usuario.TokenRecuperacao = Criptografia.CriptografarSenha(codigo);
            usuario.TokenExpiracao = DateTime.Now.AddMinutes(ExpiracaoMinutos);
            db.SaveChanges();

            await ServicoDeEmail.EnviarCodigoRecuperacaoAsync(usuario.Email, codigo);
            return true;
        }

        public static bool ValidarCodigo(string email, string codigoInformado)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios
                .FirstOrDefault(u => u.Email == email.Trim().ToLower());

            if (usuario == null) return false;
            if (usuario.TokenRecuperacao == null) return false;
            if (usuario.TokenExpiracao < DateTime.Now) return false;

            string hashInformado = Criptografia.CriptografarSenha(codigoInformado.Trim());
            return usuario.TokenRecuperacao == hashInformado;
        }

        public static bool RedefinirSenha(string email, string novaSenha)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios
                .FirstOrDefault(u => u.Email == email.Trim().ToLower());

            if (usuario == null) return false;

            usuario.Senha = Criptografia.CriptografarSenha(novaSenha);
            usuario.TokenRecuperacao = null;
            usuario.TokenExpiracao = null;
            db.SaveChanges();
            return true;
        }

        private static string GerarCodigo6Digitos()
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[4];
            rng.GetBytes(bytes);
            int numero = Math.Abs(BitConverter.ToInt32(bytes, 0)) % 1_000_000;
            return numero.ToString("D6");
        }
    }
}
