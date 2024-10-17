using System.ComponentModel.DataAnnotations;

public class Equipo
{
    [Key]
    public int IdEquipo { get; set; }

    [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre del equipo no puede exceder los 50 caracteres.")]
    public string NombreEquipo { get; set; }

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    [StringLength(50, ErrorMessage = "La ciudad no puede exceder los 50 caracteres.")]
    public string Ciudad { get; set; }

    [StringLength(200, ErrorMessage = "Los títulos del equipo no pueden exceder los 200 caracteres.")]
    public string TitulosEquipo { get; set; }

    public bool Extranjero { get; set; }
}
