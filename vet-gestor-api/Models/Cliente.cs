using System.ComponentModel.DataAnnotations;

namespace vet_gestor_api.Models;

public class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório")]
    [StringLength(14, ErrorMessage = "O CPF não pode ter mais de 14 caracteres")]
    public string? CPF { get; set; }

    [Required(ErrorMessage = "O e-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "O telefone é obrigatório")]
    [StringLength(15, ErrorMessage = "O telefone não pode ter mais de 15 caracteres")]
    public string? Telefone { get; set; }

    public virtual ICollection<Pet>? Pets { get; set; }
}
