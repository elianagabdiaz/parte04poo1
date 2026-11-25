using System;

namespace ejercicioejemplo
{
    class clasesyobjetos
    {
        internal class Animal
        {
            public string nombre;
            public int edad;

            public void Presentarse()
            {
                Console.WriteLine("Soy " + nombre + " y tengo " + edad + " años");
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("CLASES Y OBJETOS");
            Animal a1 = new Animal();
            a1.nombre = "Tobby";
            a1.edad = 3;
            a1.Presentarse();

            Animal a2 = a1;      
            a2.nombre = "Max";
            a1.Presentarse();   
        }
    }
}