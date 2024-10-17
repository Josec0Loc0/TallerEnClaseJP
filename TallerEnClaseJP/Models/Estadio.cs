using System.ComponentModel.DataAnnotations;

public class Estadio
{
    [Key]
    public int IdEstadio { get; set; }

    [Required(ErrorMessage = "La dirección es obligatoria.")]
    [StringLength(100, ErrorMessage = "La dirección no puede exceder los 100 caracteres.")]
    public string Direccion { get; set; }

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    [StringLength(50, ErrorMessage = "La ciudad no puede exceder los 50 caracteres.")]
    public string CiudadEstadio { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "La capacidad debe ser un número positivo.")]
    public int Capacidad { get; set; }
}
