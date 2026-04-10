namespace SistemaCitas.Dominio.Entidades;

public class Cita
{
    public int AppointmentId { get; set; }
    public int PatientId { get; set; }
    public DateTime DateTime { get; set; }
    public string Status { get; set; } = "Pendiente";
    public string UrgencyDescription { get; set; } = string.Empty;

    // Propiedades de navegación
    public Paciente Paciente { get; set; } = null!;
    public PuntuacionPrioridad? PuntuacionPrioridad { get; set; }
}
