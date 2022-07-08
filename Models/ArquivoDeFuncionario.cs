
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("arquivoDeFuncionarios")]
public class ArquivoDeFuncionario
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("arquivo")]
    public string Arquivo { get; set; }

    [Required]
    [Column("funcionarioId")]
    public int FuncionarioId { get; set; }
    public Funcionario Funcionario { get; set; }
}