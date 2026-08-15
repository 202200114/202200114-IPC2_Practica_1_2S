namespace Practica_IPC2.paquete_practica;

class Gato: Mascota
{

    private string Raza;
    private double Dosis;

    
    
    public Gato(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado,  string raza, double dosis) :
        base(nombre, peso, sexo, edad, propietario, codigo, estado)
    {
        this.Raza = raza;  
        this.Dosis = dosis;
    }
    
    
    public override double Calcular_Dosis() => Dosis * 0.9 * this.Peso ;
    
    public override void Mostrar_Info_2()
    {
        
        Console.WriteLine($"Raza: {this.Raza}  Dosis recomendada: {Calcular_Dosis()} mg/kg");

    }


    
}