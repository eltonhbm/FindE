using FindE.Features.Estagiario.Models;

namespace FindE.Features.Candidato.Models
{
    public class CandidatoModel
    {
        public int Id { get; set; }
        public EstagiarioModel Estagiario { get; set; }
        public DateTime DataDaCandidatura  { get; set; }
        public string Descricao { get; set; }
        public string FormacaoAcademica { get; set; }
        public StatusFormacaoEnum StatusFomacao { get; set; }
        public DateTime DataDaFormacao { get; set; }
        public string UsuarioGitHub { get; set; }
        public string UsuarioInstagram { get; set; }
        public string Whatsapp { get; set; }
        public List<CandidatoAnexo> Anexos { get; set; }

        public CandidatoModel()
        {
            Anexos = new List<CandidatoAnexo>();
        }
    }
}
