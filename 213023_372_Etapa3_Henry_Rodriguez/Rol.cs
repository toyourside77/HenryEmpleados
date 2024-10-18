using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_372_Etapa3_Henry_Rodriguez
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Rol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString() 
        {
            return Nombre;
        }
    }
}
