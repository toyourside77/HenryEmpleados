using _213023_372_Etapa3_Henry_Rodriguez;
using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();
        int numeroOpcion;
        do
        {
            Console.WriteLine("1. Crear Administrador");
            Console.WriteLine("2. Crear Encargado de almacen");
            Console.WriteLine("3. Listar Usuarios");
            Console.WriteLine("4. Salir");

            numeroOpcion = int.Parse(Console.ReadLine());

            switch (numeroOpcion)
            {
                case 1:
                    CrearAdministrador(empleados);
                    break;
                case 2:
                    break;
                case 3:
                    ListaEmpleados(empleados);
                    break;
                case 4:
                    Console.WriteLine("Salir.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (numeroOpcion != 5);
    }

    static void CrearAdministrador(List<Empleado> empleados)
    {
        Console.Write("Introduce el ID del administrador: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Introduce el nombre del administrador: ");
        string nombre = Console.ReadLine();

        Administrador nuevoUsuario = Administrador.CrearAdministrado(id, nombre);
        empleados.Add(nuevoUsuario);
        Console.WriteLine("Administrador creado con éxito.");
    }

    static void ListaEmpleados(List<Empleado> empleados)
    {
        Console.WriteLine("Lista de empleados:");
        foreach (var empleado in empleados)
        {
            empleado.MostrarEmpleados();
        }
    }
}