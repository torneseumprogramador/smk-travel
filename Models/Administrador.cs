
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smk_travel.Models;

[Table("administradores")]
public class Administrador
{
    [Key]
    [Required]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("nome")]
    public string Nome { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("email")]
    public string Email { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("senha")]
    public string Senha { get; set; }
}