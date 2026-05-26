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

        /// <summary>Gera token, salva no BD e envia email. Retorna false se email não existir.</summary>
        public static bool SolicitarRecuperacao(string email)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios
                .FirstOrDefault(u => u.Email == email.Trim().ToLower());

            if (usuario == null) return false;

            // Código de 6 dígitos criptograficamente seguro
            string codigo = GerarCodigo6Digitos();

            // Hash do código antes de salvar (mesmo princípio da senha)
            usuario.TokenRecuperacao = Criptografia.CriptografarSenha(codigo);
            usuario.TokenExpiracao = DateTime.Now.AddMinutes(ExpiracaoMinutos);

            db.SaveChanges();

            // Envia o código original (não o hash) por email
            ServicoDeEmail.EnviarCodigoRecuperacao(usuario.Email, codigo);

            return true;
        }

        /// <summary>Valida código informado pelo usuário.</summary>
        public static bool ValidarCodigo(string email, string codigoInformado)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios
                .FirstOrDefault(u => u.Email == email.Trim().ToLower());

            if (usuario == null) return false;
            if (usuario.TokenRecuperacao == null) return false;
            if (usuario.TokenExpiracao < DateTime.Now) return false; // expirado

            string hashInformado = Criptografia.CriptografarSenha(codigoInformado.Trim());
            return usuario.TokenRecuperacao == hashInformado;
        }

        /// <summary>Redefine a senha após validação bem-sucedida.</summary>
        public static bool RedefinirSenha(string email, string novaSenha)
        {
            using var db = new AppDbContext();

            var usuario = db.Usuarios
                .FirstOrDefault(u => u.Email == email.Trim().ToLower());

            if (usuario == null) return false;

            usuario.Senha = Criptografia.CriptografarSenha(novaSenha);
            usuario.TokenRecuperacao = null; // invalida token após uso
            usuario.TokenExpiracao = null;

            db.SaveChanges();
            return true;
        }

        // Gera código de 6 dígitos via RNGCryptoServiceProvider (seguro)
        private static string GerarCodigo6Digitos()
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[4];
            rng.GetBytes(bytes);
            int numero = Math.Abs(BitConverter.ToInt32(bytes, 0)) % 1_000_000;
            return numero.ToString("D6"); // garante 6 dígitos com zeros à esquerda
        }
    }
}
