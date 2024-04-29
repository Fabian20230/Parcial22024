using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS
{
    internal class Animal
    {
        public string nombre { get; set; }
        public int edad { get; set; }
         public string tipo {  get; set; }
        public virtual void sonido()
        {
            Console.WriteLine("El animal hace sonidos");
        }



    }
}
