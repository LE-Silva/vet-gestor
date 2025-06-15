using System.ComponentModel.DataAnnotations;

namespace vet_gestor_api.Models;

public class Pet
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(50, ErrorMessage = "O nome não pode ter mais de 50 caracteres")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A espécie é obrigatória")]
    [StringLength(50, ErrorMessage = "A espécie não pode ter mais de 50 caracteres")]
    public string? Especie { get; set; }

    [Required(ErrorMessage = "A raça é obrigatória")]
    [StringLength(50, ErrorMessage = "A raça não pode ter mais de 50 caracteres")]
    public string? Raca { get; set; }

    public int ClienteId { get; set; }
}
