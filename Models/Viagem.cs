
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
    [Column("CompanhiaAereaId")]
    public int CompanhiaAereaId { get; set; }
    public CompanhiaAerea CompanhiaAerea { get; set; }

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

    [Required]
    [Column("documento")]
    public string Documento { get; set; }

    [Required]
    [Column("motivoId")]
    public int MotivoId { get; set; }
    public Motivo Motivo { get; set; }

    [Required]
    [Column("classeId")]
    public int Classeid { get; set; }
    public Classe Classe { get; set; }

    [Required]
    [Column("tipoDeBilheteId")]
    public int TipoDeBilheteId { get; set; }
    public TipoDeBilhete TipoDeBilhete { get; set; }

    [Required]
    [Column("estadoDaViagemId")]
    public int EstadoDaViagemId { get; set; }
    public EstadoDaViagem EstadoDaViagem { get; set; }

    [Required]
    [Column("valor")]
    public double Valor { get; set; }

    [Required]
    [Column("taxa")]
    public double Taxa { get; set; }

    [Required]
    [Column("taxa1")]
    public double Taxa1 { get; set; }
}