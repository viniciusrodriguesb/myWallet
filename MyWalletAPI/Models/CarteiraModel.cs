namespace MyWalletAPI.Models
{
    public class CarteiraModel
    {
        public int Id { get; set; }
        public string nomeCarteira { get; set; }

        public double dinheiro { get; set; }

        public UsuarioModel id_Usuario { get; set; }

        public BancoModel id_banco { get; set; }
    }
}
