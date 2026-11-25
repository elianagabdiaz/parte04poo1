using System;

namespace ejercicioejemplo
{
    class sobrecarga
    {
        internal class Animal
        {
            public string Nombre { get; set; }
            public void Comer()
            {
                Console.WriteLine(Nombre + " come su comida de siempre");
            }

            public void Comer(string alimento)
            {
                Console.WriteLine(Nombre + " come " + alimento);
            }

            public void Comer(string alimento, int cantidad)
            {
                Console.WriteLine(Nombre + " come " + cantidad + " porciones de " + alimento);
            }
            public void Jugar(string juguete)
            {
                Console.WriteLine(Nombre + " juega con " + juguete);
            }

            public void Jugar(int minutos)
            {
                Console.WriteLine(Nombre + " juega durante " + minutos + " minutos");
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("SOBRECARGA DE MÉTODOS");
            Animal a = new Animal { Nombre = "Firulais" };

            Console.WriteLine("Por número de parámetros");
            a.Comer();
            a.Comer("carne");
            a.Comer("croquetas", 2);

            Console.WriteLine("Por tipo de parámetros");
            a.Jugar("pelota");
            a.Jugar(30);
        }
    }
}