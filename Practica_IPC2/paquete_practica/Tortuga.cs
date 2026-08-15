namespace Practica_IPC2.paquete_practica;

class Tortuga: Mascota

{
    private String Tipo_De_Tortuga;
    private double Dosis;

    public Tortuga(String nombre, int peso, string sexo, int edad, string propietario, string codigo, string estado, string tipo) :
        base(nombre, peso, sexo, edad, propietario, codigo, estado)
    {
        
        this.Tipo_De_Tortuga = tipo; //Cuando se le nombre, se le deberia decir: Es una tortuga acuatica/terrestre

    }

    public override double Calcular_Dosis(double dosis_por_Kg)
    {

        this.Dosis = dosis_por_Kg * 0.8 * this.Peso;
        
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
        
        Console.WriteLine($"Es una tortuga: {this.Tipo_De_Tortuga}  Dosis recomendada: {DosisMostrar()} ");

    }

    
}