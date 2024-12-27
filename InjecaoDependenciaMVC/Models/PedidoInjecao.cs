using InjecaoDependenciaMVC.Services;

namespace InjecaoDependenciaMVC.Models;

public class PedidoInjecao : IPedido
{
    public int PedidoId { get; set; }
    public int ClienteID { get; set; }
    public List<PedidoInjecao> GetPedidoInjecao()
    {
        var pedidos = new List<PedidoInjecao>();
        pedidos.Add(new PedidoInjecao() { PedidoId = 1, ClienteID = 1 });

        return pedidos;
    }
}
