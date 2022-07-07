
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("processos")]
public class Processo
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("funcionarioId")]
    public int FuncionarioId { get; set; }
    public Funcionario Funcionario { get; set; }

    [Required]
    [Column("itinerarioId")]
    public int ItinerarioId { get; set; }
    public Itinerario Itinerario { get; set; }

    [Required]
    [Column("siteId")]
    public int SiteId { get; set; }
    public Site Site { get; set; }

    [Required]
    [Column("dataSaida")]
    public DateTime DataSaida { get; set; }

    [Required]
    [Column("dataChagada")]
    public DateTime DataChagada { get; set; }

    [Required]
    [Column("motivoId")]
    public int MotivoId { get; set; }
    public Motivo Motivo { get; set; }

    [Required]
    [Column("testeCovid")]
    public Boolean TesteCovid { get; set; }

    [Required]
    [Column("comentarios", TypeName = "Text")]
    public string Comentarios { get; set; }

    [Required]
    [Column("diasDeTrabalho")]
    public int DiasDeTrabalho { get; set; }

    [Required]
    [Column("data")]
    public DateTime Data { get; set; }

    [Required]
    [Column("dataCriacao")]
    public DateTime DataCriacao { get; set; }

    [Required]
    [Column("dataAtualizacao")]
    public DateTime DataAtualizacao { get; set; }
}