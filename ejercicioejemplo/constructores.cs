using System;

namespace ejercicioejemplo
{
    class constructores
    {
        internal class Animal
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Animal()
            {
                Nombre = "Sin nombre";
                Edad = 0;
                Console.WriteLine("Se creó un animal sin datos");
            }

            public Animal(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
                Console.WriteLine("Se creó a " + nombre);
            }

            public Animal(Animal otro)
            {
                Nombre = otro.Nombre;
                Edad = otro.Edad;
                Console.WriteLine("Se copió a " + otro.Nombre);
            }

            public void Presentarse()
            {
                Console.WriteLine("Soy " + Nombre + " y tengo " + Edad + " años");
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("CONSTRUCTORES");
            Animal a1 = new Animal();              
            Animal a2 = new Animal("Firulais", 3);  
            Animal a3 = new Animal(a2);              

            a3.Nombre = "Copia"; 

            Console.WriteLine("Presentaciones");
            a1.Presentarse();
            a2.Presentarse();
            a3.Presentarse();
        }
    }
}