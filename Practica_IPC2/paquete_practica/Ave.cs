namespace Practica_IPC2.paquete_practica;

class Ave: Mascota
{
    private String Vuelo;
    private double Dosis;

    public Ave(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado, bool vuelo) :
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
        

        
    }
    
    public override double Calcular_Dosis(double dosis_por_Kg)
    {

        this.Dosis = dosis_por_Kg * 0.5 * this.Peso;
        
        return this.Dosis;
    }
    
    public string DosisMostrar()
    {
        if (this.Dosis == 0)
        {
            return "Todavía no se recetado una medicina" ;
        }

        else {

            return "es: " + this.Dosis + " mg/kg" ;
        }
    }

    
    

    public override void Mostrar_Info_2()
    {
        
        Console.WriteLine($"¿Puede volar la mascota?: {this.Vuelo}  Dosis recomendada: {DosisMostrar()} ");

    }

    
}