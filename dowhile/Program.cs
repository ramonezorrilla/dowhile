using System;

class Program
{
    static void Main()
    {
        string nombre, apellido, respuesta = "";
        bool continuar;

        do
        {


            {
                Console.WriteLine("Ingrese su nombre: \n");
                nombre = Console.ReadLine().Trim();

                Console.WriteLine("Ingrese su apellido: \n");
                apellido = Console.ReadLine().Trim();

                Console.WriteLine($"Hola, {nombre} {apellido}!");

                Console.WriteLine(" Desea ingresar otro nombre y apellido? (s/n)");
                respuesta = Console.ReadLine().ToLower();

                continuar = (respuesta == "s");
    

        }


        } while (continuar);


        Console.WriteLine("Gracias por utilizar este programa. Presione cualquier tecla para salir");
        Console.ReadKey();
    
    
    }


}