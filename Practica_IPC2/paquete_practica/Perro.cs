namespace Practica_IPC2.paquete_practica;

//Importante ver que una clase hija, NO PUEDE ser publica, solo se puede declarar por default class Perro: Mascota
class Perro: Mascota
{
    private string Tamanio;
    private string Raza;
    private string Vacuna_Antirabica;
    private double Dosis;
    
    public Perro(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado, string tamanio, string raza, bool vacuna, double dosis) :
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
        this.Dosis = dosis;
        
        
    }

    public override double Calcular_Dosis() => Dosis * this.Peso ;

    public override void Mostrar_Info_2()
    {
        
        Console.WriteLine($"Raza: {this.Raza}  Tamanio: {this.Tamanio} Dosis recomendada: {Calcular_Dosis()} mg/kg" +
                          $" \n  ¿Tiene la vacuna antirabica? {this.Vacuna_Antirabica}   "  );

    }
}