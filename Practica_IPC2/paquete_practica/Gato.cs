namespace Practica_IPC2.paquete_practica;

class Gato: Mascota
{

    private string Raza;
    private double Dosis = 0;

    
    
    public Gato(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado,  string raza) :
        base(nombre, peso, sexo, edad, propietario, codigo, estado)
    {
        this.Raza = raza;  

    }


    public override double Calcular_Dosis(double dosis_por_Kg)
    {

        this.Dosis = dosis_por_Kg * 0.9 * this.Peso;
        
        return this.Dosis;
    }

    public string DosisMostrar()
    {
        if (this.Dosis == 0)
        {
            return "Todavía no se recetado una medicina";
        }

        else {

            return "es: " + this.Dosis + " mg/kg";
        }
    }

    public override void Mostrar_Info_2()
    {
        
        Console.WriteLine($"Raza: {this.Raza}  La dosis recomendada  {DosisMostrar()} ");

    }


    
}