using FindE.Features.Empresa.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindE.Features.Vaga.Models
{
    public class VagaModel
    {
        public int Id { get; set; }
        public EmpresaModel Empresa { get; set; }
        public DateTime DataDeAberturaDaVaga { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public string? Anexo { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        public VagaModel()
        {
            Empresa = new EmpresaModel();
        }
    }
}
