
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("funcionarios")]
public class Funcionario
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("codigo")]
    [MaxLength(50)]
    public string Codigo { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("nome")]
    public string Nome { get; set; }

    [Required]
    [Column("departamentoId")]
    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; }

    [Required]
    [Column("centroDeCustoId")]
    public int CentroDeCustoId { get; set; }
    public CentroDeCusto CentroDeCusto { get; set; }
    
}