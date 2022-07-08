
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("SituacaoViagens")]
public class SituacaoViagem
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("ViagemId")]
    public int ViagemId { get; set; }
    public Viagem Viagem { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("situacao")]
    public string Situacao { get; set; }

    [Required]
    [Column("data")]
    public DateTime Data { get; set; }
}