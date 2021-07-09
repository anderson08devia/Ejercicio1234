using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class Loro :Clase,Avevoladora
    {
        public Loro(int numero):base(numero) { }


        public new string Numero { get; set; }

        public override void Comer()
        {
            Console.WriteLine($"El Loro puede Comer{Numero}");
        }

        public void Volar()
        {
            Console.WriteLine($"El Loro puede Volar{Numero}");
        }
    }
}
