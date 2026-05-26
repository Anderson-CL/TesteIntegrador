using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public static class ServicoDeEmail
    {
        // ⚠️ Mova essas configs para um arquivo de configuração ou variável de ambiente
        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string RemetenteEmail = "seuemail@gmail.com";   // seu Gmail
        private const string RemetenteSenha = "sua_senha_de_app";     // App Password do Google

        public static void EnviarCodigoRecuperacao(string destinatario, string codigo)
        {
            using var cliente = new SmtpClient(SmtpHost, SmtpPort)
            {
                Credentials = new NetworkCredential(RemetenteEmail, RemetenteSenha),
                EnableSsl = true,
            };

            var mensagem = new MailMessage
            {
                From = new MailAddress(RemetenteEmail, "CaixaIntegrador"),
                Subject = "Recuperação de Senha",
                IsBodyHtml = true,
                Body = $@"
                    <div style='font-family:Arial;max-width:480px;margin:auto'>
                      <h2 style='color:#1976D2'>Recuperação de Senha</h2>
                      <p>Seu código de verificação é:</p>
                      <div style='font-size:36px;font-weight:bold;
                                  letter-spacing:8px;color:#1976D2;
                                  padding:16px;background:#f0f4ff;
                                  border-radius:8px;text-align:center'>
                        {codigo}
                      </div>
                      <p style='color:#888;font-size:13px'>
                        Este código expira em <b>15 minutos</b>.<br>
                        Se não foi você, ignore este email.
                      </p>
                    </div>"
            };

            mensagem.To.Add(destinatario);
            cliente.Send(mensagem);
        }
    }
}
