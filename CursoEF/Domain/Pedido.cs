using CursoEF.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Domain;
public class Pedido
{
    public int Id { get; set; }
    public int ClienteId { get; set; }

    [NotMapped]
    public Cliente Cliente { get; set; }
    public DateTime IniciadoEm { get; set; }
    public DateTime FinalizadoEm { get; set; }
    public TipoFrete TipoFrete { get; set; }
    public StatusPedido StatusPedido { get; set; }
    public string Observacao { get; set; }
    public List<PedidoItem> Itens { get; set; }

    public Pedido() { }
    
    /*
    public Pedido(
        int id, int clienteId, Cliente cliente, DateTime iniciadoEm, DateTime finalizadoEm, 
        TipoFrete tipoFrete, StatusPedido statusPedido, string observacao, List<PedidoItem> itens)
    {
        Id = id;
        ClienteId = clienteId;
        Cliente = cliente;
        IniciadoEm = iniciadoEm;
        FinalizadoEm = finalizadoEm;
        TipoFrete = tipoFrete;
        StatusPedido = statusPedido;
        Observacao = observacao;
        Itens = itens;
    }
    */
}

