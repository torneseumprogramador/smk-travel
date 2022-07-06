
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("viagens")]
public class Viagem
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
    [Column("companhiaAeriaId")]
    public int CompanhiaAeriaId { get; set; }
    public CompanhiaAeria CompanhiaAeria { get; set; }

    [Required]
    [Column("dataSaida")]
    public DateTime DataSaida { get; set; }

    [Required]
    [Column("dataChagada")]
    public DateTime DataChagada { get; set; }

    [Required]
    [Column("alojamentoId")]
    public int AlojamentoId { get; set; }
    public Alojamento Alojamento { get; set; }

    [Required]
    [Column("testeCovid")]
    public Boolean TesteCovid { get; set; }

    [Required]
    [Column("comentarios", TypeName = "Text")]
    public string Comentarios { get; set; }

    [Required]
    [Column("hospede")]
    public Boolean Hospede { get; set; }

    [Required]
    [Column("diasDeTrabalho")]
    public int DiasDeTrabalho { get; set; }

    [Required]
    [Column("dataCriacao")]
    public DateTime DataCriacao { get; set; }

    [Required]
    [Column("dataAtualizacao")]
    public DateTime DataAtualizacao { get; set; }
}