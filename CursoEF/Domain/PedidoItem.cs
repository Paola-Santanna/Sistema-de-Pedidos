using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Domain;
public class PedidoItem
{
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; }
    public ICollection<Produto> Produtos { get; set; }
    public int Quantidade { get; set; }
    public float Valor {  get; set; }
    public float Desconto { get; set; }

    public PedidoItem() { }
    /*
    public PedidoItem(int id, int pedidoId, ICollection<Produto> produtos, int quantidade, float valor, float desconto)
    {
        Id = id;
        PedidoId = pedidoId;
        Produtos = produtos;
        Quantidade = quantidade;
        Valor = valor;
        Desconto = desconto;
    }
    */
}

