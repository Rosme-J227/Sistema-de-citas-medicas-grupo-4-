using Microsoft.EntityFrameworkCore;
using SistemaCitas.Dominio.Entidades;

namespace SistemaCitas.Infraestructura.Persistencia;

public class SistemaCitasDbContext : DbContext
{
    public SistemaCitasDbContext(DbContextOptions<SistemaCitasDbContext> options) : base(options)
    {
    }

    public DbSet<Paciente> Pacientes { get; set; } = null!;
    public DbSet<Cita> Citas { get; set; } = null!;
    public DbSet<CondicionMedica> CondicionesMedicas { get; set; } = null!;
    public DbSet<PuntuacionPrioridad> PuntuacionesPrioridad { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Paciente>().HasKey(p => p.PatientId);
        modelBuilder.Entity<Cita>().HasKey(c => c.AppointmentId);
        modelBuilder.Entity<CondicionMedica>().HasKey(cm => cm.ConditionId);
        modelBuilder.Entity<PuntuacionPrioridad>().HasKey(pp => pp.ScoreId);
        modelBuilder.Entity<Usuario>().HasKey(u => u.UserId);

        modelBuilder.Entity<Cita>()
            .HasOne(c => c.Paciente)
            .WithMany(p => p.Citas)
            .HasForeignKey(c => c.PatientId);

        modelBuilder.Entity<CondicionMedica>()
            .HasOne(cm => cm.Paciente)
            .WithMany(p => p.CondicionesMedicas)
            .HasForeignKey(cm => cm.PatientId);

        modelBuilder.Entity<PuntuacionPrioridad>()
            .HasOne(pp => pp.Cita)
            .WithOne(c => c.PuntuacionPrioridad)
            .HasForeignKey<PuntuacionPrioridad>(pp => pp.AppointmentId);
    }
}
