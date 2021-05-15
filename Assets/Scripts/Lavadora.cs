using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtadoDiego
{
    class Lavadora : Lavanderia
    {
        float voltaje;
        float capacidad;
        
        public Lavadora(string durabilidad, string material, string precio, string nombre) : base(durabilidad,material,precio,nombre)
        {

        }


    }
}
