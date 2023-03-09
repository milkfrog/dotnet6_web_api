using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O titulo é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genero é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho máximo é 50 char")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 a 600min")]
    public int Duracao { get; set; }    
}
