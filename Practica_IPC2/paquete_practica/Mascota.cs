namespace Practica_IPC2.paquete_practica;

abstract class Mascota
{
    /* iMPORTANTE destacar que al hacer esto, creamos automaticamente los
     get and set que si quieremos podemos poner privados para que no se usen
     mas alla de en esta clase, por lo que no se podrian obtener o setear de otra manera
     que no sea por metodos en esta misma clase. También acalrar que al hacer
    public string Nombre { get; set; } es lo mismo que hacer     public string Nombre { get; set; } = null;
    Por lo qu eno hay ningun problema ocn tener que llenar los datos, ya estan por defecto
    en null */
    
    protected  string Nombre { get; set; }
    protected  int    Peso { get; set; }
    protected  string Sexo { get; set; }
    protected  int    Edad { get; set; }
    protected  string Propietario { get; set; }
    protected string Codigo;

    public void Scodigo(string Id)
    {
        Codigo = Id;

    }
    
    public string Gcodigo()
    {
        return Codigo;

    }
    
    
    protected  string Estado { get; set; }

    public Mascota(String nombre, int peso, string sexo, int edad,  string propietario, string codigo, string estado)
    {
        
        this.Nombre = nombre;
        this.Peso = peso;
        this.Edad = edad;
        this.Sexo = sexo;
        this.Propietario = propietario;
        this.Codigo = codigo;
        this.Estado = estado;
    }

    public abstract double Calcular_Dosis(double dosis_por_Kg);
//La variable booleana se escribe bool no boolean
    public void Cambiar_Estado(bool estado)
    {
        if (estado)
        {
            this.Estado = "sano";
        }
        else
        {
            this.Estado = "enfermo";
        }
    }

    public void Mostrar_Info()
    {
        
        Console.WriteLine($"Nombre: {this.Nombre}  Peso: {this.Peso} Sexo: {this.Sexo}  Propietario: {this.Propietario} \n " +
                          $"Codigo: {this.Codigo}  Estado: {this.Estado} " );    
        
    }
    
    
    public abstract void Mostrar_Info_2();



}