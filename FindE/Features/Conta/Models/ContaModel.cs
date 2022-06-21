namespace FindE.Features.Conta.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public PerfilEnum Perfil { get; set; }
    }
}
