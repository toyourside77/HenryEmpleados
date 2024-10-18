using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_372_Etapa3_Henry_Rodriguez
{
    internal class Pedido
    {

        //Henry Mauricio Rodriguez Reina

        //Atributos

        public int id;
        public DateInterval fecha;
        public string estado;
        public string listaProductos;

        //Metodos

        public void realizarPedido()
        {
            Console.WriteLine(listaProductos + "Lista de Productos" + "\n ");
        }
    }
}
