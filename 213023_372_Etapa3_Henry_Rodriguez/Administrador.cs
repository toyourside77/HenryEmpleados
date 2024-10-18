using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_372_Etapa3_Henry_Rodriguez
{

    public class Administrador : Empleado 
    {
        public Administrador(int id, string nombre): base(id,nombre,new Rol(1,"Administrador"))
        {

        }

        public static Administrador CrearAdministrado(int id, string nombre)
        {
            return new Administrador(id, nombre);
        }

    }

    //Henry Mauricio Rodriguez Reina

    //Atributos

    //Metodos

}
