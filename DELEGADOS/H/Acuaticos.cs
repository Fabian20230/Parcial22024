using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS.H
{
    internal class Acuaticos : Animal
    {
        private double profundidadNado = 3; //Encapsulacion

        public int cantDientes { get; set; } 


        public void sumergir(string nombre)//Polimorfismo
        {
            this.nombre = nombre;
            Console.WriteLine($"{nombre} esta sumergido a: {profundidadNado} mts de profundidad");
        }

        public void sumergir(string nombre,  int mas) //Polimorfismo
        {
            profundidadNado = profundidadNado + mas;
            Console.WriteLine($"{nombre} esta sumergido a: {profundidadNado} mts de profundidad");
        }

        public override void sonido()//Polimorfismo
        {
            Console.WriteLine("El pez hace glu glu glu glu");
        }

    }
}
