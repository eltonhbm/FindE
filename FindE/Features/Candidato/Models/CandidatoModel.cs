using FindE.Features.Estagiario.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindE.Features.Candidato.Models
{
    public class CandidatoModel
    {
        public int Id { get; set; }
        public EstagiarioModel Estagiario { get; set; }
        public DateTime DataDaCandidatura  { get; set; }
        public string Descricao { get; set; }
        public string? FormacaoAcademica { get; set; }
        public StatusFormacaoEnum StatusFomacao { get; set; }
        public DateTime DataDaFormacao { get; set; }
        public string? UsuarioGitHub { get; set; }
        public string? UsuarioInstagram { get; set; }
        public string? Anexo { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }
    }
}
