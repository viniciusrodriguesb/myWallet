namespace MyWalletAPI.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string conteudo { get; set; }

        public double dinheiro { get; set; }

        public UsuarioModel id_usuario { get; set; }

        public CarteiraModel id_carteira { get; set; }

        public BancoModel id_banco { get; set; }
    }
}
