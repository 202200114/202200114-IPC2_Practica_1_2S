namespace Practica_IPC2.paquete_practica;

class Tortuga: Mascota

{
    private String Tipo_De_Tortuga;
    private double Dosis;

    public Tortuga(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado, string tipo, double dosis) :
        base(nombre, peso, sexo, edad, propietario, codigo, estado)
    {
        
        this.Tipo_De_Tortuga = tipo; //Cuando se le nombre, se le deberia decir: Es una tortuga acuatica/terrestre
        this.Dosis = dosis;
    }
    
    public override double Calcular_Dosis() => Dosis * 0.8 * this.Peso ;


    public override void Mostrar_Info_2()
    {
        
        Console.WriteLine($"Es una tortuga: {this.Tipo_De_Tortuga}  Dosis recomendada: {Calcular_Dosis()} mg/kg");

    }

    
}