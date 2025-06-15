using System.ComponentModel.DataAnnotations;

namespace vet_gestor_api.Models;

public class Consulta
{
    public int Id { get; set; }

    [Required(ErrorMessage = "A data da consulta é obrigatória")]
    public DateTime DataConsulta { get; set; }

    [Required(ErrorMessage = "O horário da consulta é obrigatório")]
    public TimeSpan Horario { get; set; }

    [StringLength(1000, ErrorMessage = "A descrição não pode ter mais de 1000 caracteres")]
    public string? Descricao { get; set; }

    public int PetId { get; set; }
    public virtual Pet? Pet { get; set; }

    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }
}
