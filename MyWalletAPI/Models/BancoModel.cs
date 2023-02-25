namespace MyWalletAPI.Models
{
    public class BancoModel
    {
        public int Id { get; set; }

        public string banco { get; set; }

        public UsuarioModel id_usuario { get; set; }
    }
}
