using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtadoDiego
{
    class Secado : Lavadora
    {
        string modelo;
        int tiempo;

        public Secado(string durabilidad, string material, string precio, string nombre) : base(durabilidad, material, precio, nombre)
        {

        }

    }
}
