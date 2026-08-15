namespace Practica_IPC2.paquete_practica;

//Importante ver que una clase hija, NO PUEDE ser publica, solo se puede declarar por default class Perro: Mascota
class Perro: Mascota
{
    private string Tamanio;
    private string Raza;
    private string Vacuna_Antirabica;
    private double Dosis = 0;
    
    public Perro(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado, string tamanio, string raza, bool vacuna) :
        base(nombre, peso, sexo, edad, propietario, codigo, estado)
    {
        
        if(vacuna)
        {
            this.Vacuna_Antirabica = "sí, tiene la vacuna antirabica";
            
        }
        else
        {
            this.Vacuna_Antirabica = "no, no se le ha administrado la vacuna antirabica";
        }
        this.Tamanio = tamanio;
        this.Raza = raza;

        
        
    }

    public override double Calcular_Dosis(double dosis_por_Kg)
    {

        this.Dosis = dosis_por_Kg  * this.Peso;
        
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
        
        Console.WriteLine($"Raza: {this.Raza}  Tamanio: {this.Tamanio} Dosis recomendada: {DosisMostrar()} " +
                          $" \n  ¿Tiene la vacuna antirabica? {this.Vacuna_Antirabica}   "  );

    }
}