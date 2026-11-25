using System;

namespace ejercicioejemplo
{
    class estaticos
    {
        internal class Animal
        {
            public string Nombre;

            public static int TotalAnimales = 0;


            static Animal()
            {
                Console.WriteLine(">> Constructor static: corre UNA sola vez");
            }

            public Animal(string nombre)
            {
                Nombre = nombre;
                TotalAnimales++;   
            }
            public static void MostrarTotal()
            {
                Console.WriteLine("Total de animales creados: " + TotalAnimales);
            }
        }

        internal static class Veterinaria
        {
            public static string Nombre = "Patitas Felices";

            public static int CalcularEdadHumana(int edadPerro)
            {
                return edadPerro * 7;
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("STATIC");
            Console.WriteLine("Inicio del programa");

            Animal.MostrarTotal();           

            Animal a1 = new Animal("Firulais");
            Animal a2 = new Animal("Michi");
            Animal a3 = new Animal("Toby");
            Animal.MostrarTotal();            

            Console.WriteLine("Veterinaria: " + Veterinaria.Nombre);
            Console.WriteLine("Un perro de 3 años equivale a "
                + Veterinaria.CalcularEdadHumana(3) + " años humanos");

        }
    }
}