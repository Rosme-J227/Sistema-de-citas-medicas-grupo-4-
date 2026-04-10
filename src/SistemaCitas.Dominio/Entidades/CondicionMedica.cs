namespace SistemaCitas.Dominio.Entidades;

public class CondicionMedica
{
    public int ConditionId { get; set; }
    public int PatientId { get; set; }
    public string ConditionName { get; set; } = string.Empty;
    public DateTime DiagnosisDate { get; set; }

    // Propiedades de navegación
    public Paciente Paciente { get; set; } = null!;
}
