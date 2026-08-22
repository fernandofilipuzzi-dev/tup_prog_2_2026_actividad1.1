namespace Ejercicio1.Models;

class Cocina
{

    public Alacena Alacena { get; private set; }
    public Amasador Amasador { get; private set; }
    public Cocinera Cocinera { get; private set; }

    public Cocina(Alacena alacena,  Amasador amasador, Cocinera cocinera)
    {
        this.Alacena = alacena;//4
        this.Amasador = amasador;//5
        this.Cocinera = cocinera;//6
    }
}
