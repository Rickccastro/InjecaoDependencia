namespace InjecaoDependenciaMVC.Models;

public class Cliente
{
    Pedido meuPedido = new Pedido();

    public List<Pedido> ObterPedidos()
    {
        return meuPedido.GetPedidos();
    }

}
