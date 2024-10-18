using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_372_Etapa3_Henry_Rodriguez
{
    internal class Proveedor
    {
        //Henry Mauricio Rodriguez Reina

        //Atributo

        public int numeroId;
        public string nombre;
        public string listaProductos;

        //Metodos

        public void registrarProveedor()
        {
            Console.WriteLine(nombre + "nombre del Proveedor" + numeroId + "\n más detalles");
        }
        public void gestionarListaProducto()
        {
            Console.WriteLine(listaProductos + "productos" + nombre + "\n más detalles");
        }
    }
}

