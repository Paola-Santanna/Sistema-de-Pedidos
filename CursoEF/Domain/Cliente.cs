using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Domain;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string CEP { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public Cliente(int id, string nome, string telefone, string cEP, string cidade, string estado)
    {
        Id = id;
        Nome = nome;
        Telefone = telefone;
        CEP = cEP;
        Cidade = cidade;
        Estado = estado;
    }
}

