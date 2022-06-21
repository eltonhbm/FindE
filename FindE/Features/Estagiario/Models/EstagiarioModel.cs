namespace FindE.Features.Estagiario.Models
{
    public class EstagiarioModel
    { public string Nome { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Curso { get; set; }
        public int Idade
        {
            get { return (DateTime.Now - DataDeNascimento).Days / 365; }
        }
    }
}
