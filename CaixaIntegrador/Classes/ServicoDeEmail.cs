using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public static class ServicoDeEmail
    {
        private const string ApiKey = "CHAVE AQUI";
        private const string RemetenteEmail = "totoraivo@gmail.com"; // email verificado no Brevo
        private const string RemetenteNome = "Adega";
        private const string ApiUrl = "https://api.brevo.com/v3/smtp/email";

        public static async Task EnviarCodigoRecuperacaoAsync(string destinatario, string codigo)
        {
            using var http = new HttpClient();
            http.DefaultRequestHeaders.Add("api-key", ApiKey);

            string corpo = $@"
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
                </div>";

            string payload = $@"{{
                ""sender"":      {{""name"":""{RemetenteNome}"",""email"":""{RemetenteEmail}""}},
                ""to"":          [{{""email"":""{destinatario}""}}],
                ""subject"":     ""Recuperação de Senha — CaixaIntegrador"",
                ""htmlContent"": ""{EscaparJson(corpo)}""
            }}";

            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            var response = await http.PostAsync(ApiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                string erro = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao enviar email ({response.StatusCode}): {erro}");
            }
        }

        private static string EscaparJson(string texto) =>
            texto.Replace("\\", "\\\\")
                 .Replace("\"", "\\\"")
                 .Replace("\r", "")
                 .Replace("\n", "");
    }
}