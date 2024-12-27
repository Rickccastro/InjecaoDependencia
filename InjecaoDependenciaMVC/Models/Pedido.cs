namespace InjecaoDependenciaMVC.Models;

public class Pedido
{
    public int PedidoId { get; set; }
    public int ClienteID { get; set; }
    public List<Pedido> GetPedidos()
    {
        var pedido = new List<Pedido>();
        pedido.Add(new Pedido { PedidoId = 1, ClienteID = 1 });
        return pedido;
    }
}
