namespace Practica_IPC2.paquete_practica;

class Ave: Mascota
{
    private String Vuelo;
    private double Dosis;

    public Ave(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado, bool vuelo, double dosis) :
        base(nombre, peso, sexo, edad, propietario, codigo, estado)
    {

        if (vuelo)
        {
            Vuelo = "Sí, puede volar";
        }
        else
        {
            Vuelo = "No, no puede volar";
        }
        
        this.Dosis = dosis;
        
    }
    
    public override double Calcular_Dosis() => Dosis * 0.5 * this.Peso ;

    public override void Mostrar_Info_2()
    {
        
        Console.WriteLine($"¿Puede volar la mascota?: {this.Vuelo}  Dosis recomendada: {Calcular_Dosis()} mg/kg");

    }

    
}