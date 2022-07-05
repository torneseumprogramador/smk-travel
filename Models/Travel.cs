
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("travels")]
public class Travel
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }

    [MaxLength(150)]
    [Column("nome")]
    [Required]
    public string Nome { get; set; }
}