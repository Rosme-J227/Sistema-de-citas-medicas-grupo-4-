namespace SistemaCitas.Dominio.Entidades;

public class Paciente
{
    public int PatientId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string ContactNum { get; set; } = string.Empty;
    
    // Navigation properties
    public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    public ICollection<CondicionMedica> CondicionesMedicas { get; set; } = new List<CondicionMedica>();
}
