using InjecaoDependenciaMVC.Services;

namespace InjecaoDependenciaMVC.Models;

public class ClienteInjecao
{
  /* Configurando o servico de injecao de dependencia Program.cs
  * builder.Services.AddTransient<IPedido,PedidoInjecao>();
   builder.Services.AddScoped<IPedido,PedidoInjecao>();
   builder.Services.AddSingleton<IPedido,PedidoInjecao>();*/

    private readonly IPedido _pedido;
    public ClienteInjecao(IPedido pedido)
    {
        this._pedido = pedido;
    }

    public List<PedidoInjecao> ObterPedidos()
    {
        return _pedido.GetPedidoInjecao();
    }
}
