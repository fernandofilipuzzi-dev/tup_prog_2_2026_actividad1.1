namespace Ejercicio1.Models;

public class Cocinera
{
    public string Nombre { get; private set; }
    public string estadoTareas;

    public Cocinera(string nombre)
    {
        this.Nombre = nombre;
    }

    
    public void CortaLaMasa()
    {
        estadoTareas = "Cortando la masa";
    }

    public void FormaLaMasa()
    {
        estadoTareas = "Formando La Masa";
    }

    public void Hornea()
    {
        estadoTareas = "Horneando";
    }

    public string ContestarEnQueEtapaEsta() 
    {
        return estadoTareas;
    }
}
