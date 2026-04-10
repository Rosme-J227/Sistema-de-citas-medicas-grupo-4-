namespace SistemaCitas.Dominio.Entidades;

public class PuntuacionPrioridad
{
    public int ScoreId { get; set; }
    public int AppointmentId { get; set; }
    public double CalculatedScore { get; set; }
    public DateTime CalculationDate { get; set; }

    // Propiedades de navegación
    public Cita Cita { get; set; } = null!;
}
