namespace MyWalletAPI.Models
{
    public class MovimentacaoModel
    {
        public int Id { get; set; }

        public DateTime dataMovimentacao { get; set; }

        public double dinheiro { get; set; }

        public TipoTransacaoModel id_tipo { get; set; }

        public CarteiraModel id_carteira { get; set; }

        public UsuarioModel id_suario { get; set; }

        public BancoModel id_banco { get; set; }
    }
}
