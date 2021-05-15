using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtadoDiego
{
    class Secadora_WTG : Secado
    {
        public Secadora_WTG(string durabilidad, string material, string precio, string nombre) : base(durabilidad, material, precio, nombre)
        {
            this.precio = precio;
            this.nombre = nombre;

        }


    }
}
