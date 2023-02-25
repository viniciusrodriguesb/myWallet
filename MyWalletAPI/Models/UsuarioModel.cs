namespace MyWalletAPI.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string nome { get; set; }

        public string usuario { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public string telefone { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public DateOnly aniversario { get; set; }
    }
}
