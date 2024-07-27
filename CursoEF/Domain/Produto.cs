using CursoEF.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Domain;
public class Produto
{
    public int Id { get; set; }
    public string CodigoDeBarras { get; set; }
    public string Descricao { get; set; }
    public float Valor {  get; set; }
    public TipoProduto TipoProduto { get; set; }
    public bool Ativo {  get; set; }

    public Produto(int id, string codigoDeBarras, string descricao, float valor, TipoProduto tipoProduto, bool ativo)
    {
        Id = id;
        CodigoDeBarras = codigoDeBarras;
        Descricao = descricao;
        Valor = valor;
        TipoProduto = tipoProduto;
        Ativo = ativo;
    }
}

