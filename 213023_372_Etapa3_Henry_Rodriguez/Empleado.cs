using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_372_Etapa3_Henry_Rodriguez
{
    public class Empleado
    {
        //Henry Mauricio Rodriguez Reina

        //Atributos

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Rol Rol { get; set; }

        public Empleado(int id, string nombre, Rol rol) 
        {
            Id = id;
            Nombre = nombre;
            Rol = rol;
        }

        //Metodos

        public virtual void MostrarEmpleados()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Rol: {Rol}");
        }
        public void registrarEmpleado()
        {
            Console.WriteLine(Nombre + "nombre del empleado" + Id + "\n más detalles");
        }
        public void asignarRol()
        {
            Console.WriteLine(Rol + "nombre del rol" + Nombre + "\n más detalles");
        } 
    }
}