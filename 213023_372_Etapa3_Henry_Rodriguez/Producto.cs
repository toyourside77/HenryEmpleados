using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_372_Etapa3_Henry_Rodriguez
{
    internal class Producto
    {
        //Henry Mauricio Rodriguez Reina

        //Atributos

        public int codigo;
        public string nombre;
        public string descripcion;
        public int precioUnitario;
        public int cantidadEnStock;

        //Metodos

        public void agregarProducto()
        {
            Console.WriteLine(codigo + "agregar producto" + cantidadEnStock + "\n más detalles");
        }
        public void eliminarProducto()
        {
            Console.WriteLine(codigo + "eliminar producto" + cantidadEnStock + "\n más detalles");
        }
        public void actualizarStock()
        {
            Console.WriteLine(cantidadEnStock + "actualizar stock" + descripcion + "\n más detalles");
        }
        public void actualizarPrecio()
        {
            Console.WriteLine(precioUnitario + "actualizar precio" + descripcion + "\n más detalles");
        }
    }
}
