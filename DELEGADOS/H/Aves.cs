using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS.H
{
    internal class Aves : Animal , IclubVoladores 
    {
        public string genero { get; set; }

        private double alturaVuelo = 5;//ENCAPSULACION porque esta propiedad es exclusiva para la clase ave   ;^)

        public string colorPlumas { get; set; }
         
        public void volar()//polimorfismo sobre los metodos
        {
            alturaVuelo++;
            Console.WriteLine($"Estas volando a: {alturaVuelo} mts");

        }
        public void volar(int nuevaa)//polimorfismo sobre los metodos
        {


            alturaVuelo = nuevaa + alturaVuelo;
            Console.WriteLine($"Estas volando a: {alturaVuelo} mts");

        }

        public override void sonido() //Polimorfismo
        {
            Console.WriteLine("El ave hace trrrrrrrriiii");
        }





    }
}
