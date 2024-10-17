using System.ComponentModel.DataAnnotations;

public class Jugador
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "La posición es obligatoria.")]
    [StringLength(30, ErrorMessage = "La posición no puede exceder los 30 caracteres.")]
    public string Posición { get; set; }

    [Range(1, 100, ErrorMessage = "La edad debe estar entre 1 y 100 años.")]
    public int Edad { get; set; }

    [StringLength(200, ErrorMessage = "Los títulos no pueden exceder los 200 caracteres.")]
    public string Titulos { get; set; }

    // Relación con Equipo
    public int EquipoId { get; set; } // Clave foránea
    public virtual Equipo Equipo { get; set; } // Navegación
}
