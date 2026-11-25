using System;

namespace ejercicioejemplo
{
    class herencia
    {
        internal class Animal
        {
            public string Nombre;        
            protected int edad;         
            private string secreto = "xyz";  

            public Animal(string nombre, int edad)
            {
                Nombre = nombre;
                this.edad = edad;
                Console.WriteLine("Constructor de Animal");
            }

            public void Dormir()
            {
                Console.WriteLine(Nombre + " está durmiendo");
            }
        }

        internal class Perro : Animal
        {
            public Perro(string nombre, int edad) : base(nombre, edad)
            {
                Console.WriteLine("Constructor de Perro");
            }

            public void Ladrar()
            {
                Console.WriteLine(Nombre + " de " + edad + " años dice: ¡Guau!");
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("HERENCIA");
            Perro p = new Perro("Firulais", 3);

            p.Dormir();   
            p.Ladrar();   

        }
    }
}