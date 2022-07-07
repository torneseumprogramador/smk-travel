
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("fornecedores")]
public class Fornecedor
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
    [MaxLength(100)]
    [Column("nif")]
    public string Nif { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("morada")]
    public string Morada { get; set; }

    
    
}