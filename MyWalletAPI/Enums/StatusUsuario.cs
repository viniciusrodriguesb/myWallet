using System.ComponentModel;
namespace MyWalletAPI.Enums
{
    public enum StatusUsuario
    {   
        [Description("pode excluir contar, carteiras, etc")]
        Administrador = 1,

        [Description("só pode utilizar o app normalmente")]
        Cliente = 2,

        [Description("pode fazer a testagem e automação dos campos")]
        Testador = 3
    }
}