// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;



using Practica_IPC2.paquete_practica; //para importar librerías, se necesita usar using
//se coloca using y el nombre del paquete y así se importa
//Para que el programa ejecute y asu vez ejecuta de forma continua es necesario no solo tener un
//runtime vacio, sino debemso de crear una clase y un static void Main y así se ejecutará el programa
class practica
{

        //Además esta lsita debe de estar no dentro del main sino aquí afuera, el main solo servirá
        //para que inicie todo
    private static List<Mascota> Mascotas = new List<Mascota>();

    static void Main()
    {

        Interfaz();
    }
    
    /* StringBuilder es una clase que sirve para construir y manipular cadenas de texto de manera eficiente, siendo que mientras que un
String es inmutable y siempre se sobre escribe un dato en él, el StringBuilder permite modificar su contenido sin crear copias o estar borrando
 y sobre escribiendo instancias, sirve para concatenar o para armar un texto paso a paso, por lo que es perfecto 
 para crear el codigo unico alfanumerico Y Random, es una clase que genera números aleatorios
Así que para crear el código utilizamos ambas clases y datos normales
un String que contiene los caracteres permitidos
Y un for para que el random seleccione n veces uno de los caracteres, al tomar al  String de los caracteres
 y seleccionar uno de sus caracteres aleatoriamente.

 */
    
    // Además es importante antes de trabajar, importar las clases más arriba 
    
    
    
    //IMPORTANTE SIEMPRE, que al recorrer una lista verifiquemos que este vacia
    public static string Generar_Codigo_Unico()
    
    {
        
        string Caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; 

        int longitud = 8;
        StringBuilder sb = new StringBuilder();
        Random rd = new Random();

        bool Seguir = true;

        while(Seguir)
        {
            for (int i = 0; i < longitud; i++)
            {
                int index = rd.Next(Caracteres.Length);
                sb.Append(Caracteres[index]);
            }

            if(Mascotas.Count != 0){
                foreach (Mascota Paciente in Mascotas)
                {
                    if (Paciente.Gcodigo() == sb.ToString())
                    {
                        Seguir = true;
                        break;
                    }
                    else
                    {
                        Seguir = false;

                    }
                }
            
            }
            else
            {
                Seguir = false; //Esto es en caso de que la lista esta vacia por lo que no hay necesidad de revisar si hay codigos repetidos
            }



        }
        

        return sb.ToString();

    }
    
    
  

    static void Interfaz()
    {
        
        
        bool Salir = true;

        while (Salir)
        {
            
            Console.WriteLine("=== Veterinaria Aguas Calientes === \n\n\n Elija la opción que desee usuario");
            Console.WriteLine("1. Resgistrar una mascota\n");
            Console.WriteLine("2. Gestionar un paciente ya registrado\n");
            Console.WriteLine("3. Salir del programa\n");
            Console.Write("\n\n\n Elija la opción que desee ");
            int Opcion =  int.Parse(Console.ReadLine());


            switch (Opcion)
            {

                case 1:
                    Console.WriteLine("Seleccione el tipo de animal que desea registrar");
                    Console.WriteLine("\n Elija la opción que desee usuario");
                    Console.WriteLine("1. Perro\n");
                    Console.WriteLine("2. Gato\n");
                    Console.WriteLine("3. Ave");
                    Console.WriteLine("4. Tortuga");
                    Console.WriteLine("5. Volver a la interfaz principal");
                    Console.Write("\n\n\n Elija la opción que desee ");

                    int Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:

                            string C1 = Generar_Codigo_Unico();

                            Console.WriteLine("Ingrese el nombre del paciente");
                            string N1 = Console.ReadLine();

                            Console.WriteLine("Ingrese el peso del paciente");
                            int P1 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el sexo del paciente");
                            string S1 = Console.ReadLine();


                            Console.WriteLine("Ingrese la edad del paciente");
                            int E1 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el nombre del propietario del paciente");
                            string Pe1 = Console.ReadLine();


                            Console.WriteLine("Seleccione una de las 2 opciones para el Estado del paciente" +
                                              "\n Ingrese 1 si el paciente esta Sano, Ingrese 2 si el paciente esta enfermo");


                            int Estado_Opcion = int.Parse(Console.ReadLine());
                            string Es1 = "enfermo";
                            if (Estado_Opcion == 1)
                            {
                                Es1 = "sano";

                            }
                            else if (Estado_Opcion == 2)
                            {

                                Es1 = "enfermo";
                            }
                            else
                            {

                                Console.WriteLine(
                                    "ingreso invalido, se colocará el estado del paciente como enfermo, verificar");
                            }

                            Console.WriteLine("Ingrese el tamaño del paciente");
                            string T1 = Console.ReadLine();


                            Console.WriteLine("Ingrese la raza del paciente");
                            string R1 = Console.ReadLine();


                            Console.WriteLine("Seleccione una de las 2 opciones para la vacuna anti-rabica" +
                                              "\n Ingrese 1 si el paciente ha recibido la vacuna contra la rabia, Ingrese 2 si el paciente no ha" +
                                              "ha sido vacunado contra la rabia");


                            int Vacuna_Opcion = int.Parse(Console.ReadLine());
                            bool V1 = false;
                            if (Vacuna_Opcion == 1)
                            {
                                V1 = true;

                            }
                            else if (Vacuna_Opcion == 2)
                            {

                                V1 = false;
                            }
                            else
                            {

                                Console.WriteLine(
                                    "ingreso invalido, se colocará el estado del paciente como no vacunado, verificar");
                            }

                            Console.WriteLine("Ingrese la dosis del paciente");
                            int D1 = int.Parse(Console.ReadLine());



                            Mascota Mascota1 = new Perro(N1, P1, S1, E1, Pe1, C1, Es1, T1, R1, V1, D1);

                            Mascotas.Add(Mascota1);

                            break;

                        case 2:

                            string C2 = Generar_Codigo_Unico();
                            Console.WriteLine("Ingrese el nombre del paciente");
                            string N2 = Console.ReadLine();



                            Console.WriteLine("Ingrese el peso del paciente");
                            int P2 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el sexo del paciente");
                            string S2 = Console.ReadLine();


                            Console.WriteLine("Ingrese la edad del paciente");
                            int E2 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el nombre del propietario del paciente");
                            string Pe2 = Console.ReadLine();


                            Console.WriteLine("Seleccione una de las 2 opciones para el Estado del paciente" +
                                              "\n Ingrese 1 si el paciente esta Sano, Ingrese 2 si el paciente esta enfermo");


                            int Estado_Opcion2 = int.Parse(Console.ReadLine());
                            string Es2 = "enfermo";
                            if (Estado_Opcion2 == 1)
                            {
                                Es2 = "sano";

                            }
                            else if (Estado_Opcion2 == 2)
                            {

                                Es2 = "enfermo";
                            }
                            else
                            {

                                Console.WriteLine(
                                    "ingreso invalido, se colocará el estado del paciente como enfermo, verificar");
                            }

                            Console.WriteLine("Ingrese la raza del paciente");
                            string R2 = Console.ReadLine();


                            Console.WriteLine("Ingrese la dosis del paciente");
                            int D2 = int.Parse(Console.ReadLine());

                            Mascota Gato1 = new Gato(N2, P2, S2, E2, Pe2, C2, Es2, R2, D2);
                            Mascotas.Add(Gato1);
                            break;

                        case 3:

                            string C3 = Generar_Codigo_Unico();
                            Console.WriteLine("Ingrese el nombre del paciente");
                            string N3 = Console.ReadLine();

                            Console.WriteLine("Ingrese el peso del paciente");
                            int P3 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el sexo del paciente");
                            string S3 = Console.ReadLine();


                            Console.WriteLine("Ingrese la edad del paciente");
                            int E3 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el nombre del propietario del paciente");
                            string Pe3 = Console.ReadLine();


                            Console.WriteLine("Seleccione una de las 2 opciones para el Estado del paciente" +
                                              "\n Ingrese 1 si el paciente esta Sano, Ingrese 2 si el paciente esta enfermo");


                            int Estado_Opcion3 = int.Parse(Console.ReadLine());
                            string Es3 = "enfermo";
                            if (Estado_Opcion3 == 1)
                            {
                                Es3 = "sano";

                            }
                            else if (Estado_Opcion3 == 2)
                            {

                                Es3 = "enfermo";
                            }
                            else
                            {

                                Console.WriteLine(
                                    "ingreso invalido, se colocará el estado del paciente como enfermo, verificar");
                            }



                            Console.WriteLine("Seleccione una de las 2 opciones para el paciente ave" +
                                              "\n Ingrese 1 si el paciente puede volar, Ingrese 2 si el paciente no puede volar");


                            int Volar = int.Parse(Console.ReadLine());
                            bool V2 = true;
                            if (Volar == 1)
                            {
                                V2 = true;

                            }
                            else if (Volar == 2)
                            {

                                V2 = false;
                            }
                            else
                            {

                                Console.WriteLine("ingreso invalido, se definirá que el ave si puede volar, verificar");
                            }

                            Console.WriteLine("Ingrese la dosis del paciente");
                            int D3 = int.Parse(Console.ReadLine());


                            Mascota Ave1 = new Ave(N3, P3, S3, E3, Pe3, C3, Es3, V2, D3);
                            Mascotas.Add(Ave1);
                            break;
                        case 4:

                            string C4 = Generar_Codigo_Unico();
                            Console.WriteLine("Ingrese el nombre del paciente");
                            string N4 = Console.ReadLine();

                            Console.WriteLine("Ingrese el peso del paciente");
                            int P4 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el sexo del paciente");
                            string S4 = Console.ReadLine();


                            Console.WriteLine("Ingrese la edad del paciente");
                            int E4 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese el nombre del propietario del paciente");
                            string Pe4 = Console.ReadLine();


                            Console.WriteLine("Seleccione una de las 2 opciones para el Estado del paciente" +
                                              "\n Ingrese 1 si el paciente esta Sano, Ingrese 2 si el paciente esta enfermo");


                            int Estado_Opcion4 = int.Parse(Console.ReadLine());
                            string Es4 = "enfermo";
                            if (Estado_Opcion4 == 1)
                            {
                                Es4 = "sano";

                            }
                            else if (Estado_Opcion4 == 2)
                            {

                                Es4 = "enfermo";
                            }
                            else
                            {

                                Console.WriteLine(
                                    "ingreso invalido, se colocará el estado del paciente como enfermo, verificar");
                            }

                            Console.WriteLine("Ingrese el tipo de tortuga que es el paciente, acuatica o terrestre");
                            string R4 = Console.ReadLine();


                            Console.WriteLine("Ingrese la dosis del paciente");
                            int D4 = int.Parse(Console.ReadLine());

                            Mascota Tortuga = new Tortuga(N4, P4, S4, E4, Pe4, C4, Es4, R4, D4);
                            Mascotas.Add(Tortuga);

                            break;

                        case 5:
                            Console.WriteLine("Regresando a la interfaz principal");
                            break;


                        default:
                            Console.WriteLine("Opción inválida, intente de nuevo.");
                            break;

                    }


                    break;

                case 2:



                      if(Mascotas.Count != 0){
                          
                          bool Exit = true;
                          while (Exit)
                          {

                              Console.WriteLine("\n ¡Bienvenido al Menú de Selección de Paciente!");

                              Console.WriteLine("\n -------------- Lista de pacientes ------------------ ");

                              foreach (Mascota animal in Mascotas)
                              {
                                  animal.Mostrar_Info();
                              }

                              Console.WriteLine("\n Ingrese el ID del paciente que desee");


                              string ID = Console.ReadLine();
                              ;
                              bool Out = true;
                              
                              Mascota mascota = null;
                              
                              foreach (Mascota Paciente in Mascotas)
                              {
                                  if (Paciente.Gcodigo() == ID)
                                  {
                                      Out = true;
                                      mascota = Paciente; 
                                      break;
                                  }
                                  else
                                  {
                                      Out = false;

                                  }

                              }

                              if (!Out)
                              {
                                  Console.WriteLine("\n El ID ingresado no existe");
                              }

                              while (Out)
                              {
                                  Console.WriteLine("\n Paciente {ID} ");
                                  Console.WriteLine("\n Seleccione lo que desea hacer");
                                  Console.WriteLine("\n 1. Mostrar su información");
                                  Console.WriteLine("\n 2. Calcular su dosis");
                                  Console.WriteLine("\n 3. Cambiar su estado ");
                                  Console.WriteLine("\n 4. Volver al Menú de Selección de Paciente");


                                  int Op = int.Parse(Console.ReadLine());
                                  switch (Op)
                                  {
                                      case 1:
                                          Console.WriteLine("\n La información del paciente es:");
                                          
                                          mascota.Mostrar_Info();
                                          mascota.Mostrar_Info_2();
                                          
                                          
                                          break;

                                      case 2:
                                          Console.WriteLine("La dosis recomendada para el paciente es: ");
                                          mascota.Calcular_Dosis();
                                          break;

                                      case 3:
                                          Console.WriteLine(
                                              "Para cambiar el estado del paciente, ingrese 1 para sano y 2 para enfermo");

                                          int Seleccion = int.Parse(Console.ReadLine());
                                          bool estado = true;
                                          if (Seleccion == 1)
                                          {
                                              estado = true;

                                          }
                                          else if (Seleccion == 2)
                                          {
                                              estado = false;

                                          }
                                          else
                                          {
                                              Console.WriteLine("Entrada invalida");

                                          }

                                          break;

                                      case 4:
                                          Console.WriteLine("Regresando al Menú De Pacientes");
                                          Out = false;
                                          break;


                                      default:
                                          Console.WriteLine("Opción inválida, intenta de nuevo.");
                                          break;



                                  }



                              }

                              Console.WriteLine("¿Desea salir del Menú De Selección de Paciente? Si desea salir ingrese 1, " +
                                                "si desaea permanecer ingrese 2");

                              int Select = int.Parse(Console.ReadLine());

                              if (Select == 1)
                              {
                                  Exit = false;
                                  Console.WriteLine("Saliendo del Menú De Selección de Paciente");

                              }
                              else if (Select == 2)
                              {

                              }
                              else
                              {
                                  Exit = false;
                                  Console.WriteLine("Entrada invalida, saliendo del Menú...");

                              }


                          }


                      }
                      else
                      {
                          Console.WriteLine("En este momento no hay pacientes registrados, regresando a la interfaz....");
                          
                      }



                      break;
                
                case 3:
                    Console.WriteLine("Saliendo del programa, que tenga un buen día");
                    Salir = false; //Esto rompe el bucle while y se sale del programa

                    break;
                
                default:
                    Console.WriteLine("Opción inválida, intenta de nuevo.");
                    break;
                
            }
            
            Console.WriteLine(); // salto de línea 
            
        }

    }
    
}


