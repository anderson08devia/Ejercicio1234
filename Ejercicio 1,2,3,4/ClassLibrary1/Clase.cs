using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Clase : Avecomer
    {
        public Clase(int numero)
        {
            Numero = numero;
        }


        public int Numero { get; set; }

     
        public abstract void Comer();
       
    }
}
