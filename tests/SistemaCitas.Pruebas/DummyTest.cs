using Xunit;

namespace SistemaCitas.Pruebas;

public class DummyTest
{
    [Fact]
    public void TestBasico_DebePasar()
    {
        // Actuar
        int resultado = 1 + 1;

        // Comprobar
        Assert.Equal(2, resultado);
    }
}
