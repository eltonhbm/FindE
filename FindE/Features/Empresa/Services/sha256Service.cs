using System.Security.Cryptography;
using System.Text;

namespace FindE.Features.Empresa.Services
{
    public class sha256Service
    {
        public static string CalcularHashSha256(string conteudo)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(conteudo));

                var builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
