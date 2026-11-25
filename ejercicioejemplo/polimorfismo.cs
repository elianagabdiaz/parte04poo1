using System;

namespace ejercicioejemplo
{
    class polimorfismo
    {
        internal abstract class Animal
        {
            public string Nombre;

            public Animal(string nombre)
            {
                Nombre = nombre;
            }

            public abstract void HacerSonido();

            public virtual void Presentarse()
            {
                Console.WriteLine("Soy un animal llamado " + Nombre);
            }
        }

        internal class Perro : Animal
        {
            public Perro(string nombre) : base(nombre) { }

            public override void HacerSonido()
            {
                Console.WriteLine(Nombre + ": ¡Guau!");
            }

            public override void Presentarse()
            {
                base.Presentarse();  
                Console.WriteLine("...y además soy un perro");
            }
        }

        internal class Gato : Animal
        {
            public Gato(string nombre) : base(nombre) { }

            public override void HacerSonido()
            {
                Console.WriteLine(Nombre + ": ¡Miau!");
            }

        }

        internal sealed class Cachorro : Perro
        {
            public Cachorro(string nombre) : base(nombre) { }

            public override void HacerSonido()
            {
                Console.WriteLine(Nombre + ": ¡Guau guau!");
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("POLIMORFISMO");

            Animal[] animales = {
                new Perro("Firulais"),
                new Gato("Michi"),
                new Cachorro("Toby")
            };

            foreach (Animal a in animales)
            {
                a.Presentarse();
                a.HacerSonido();
                Console.WriteLine();
            }
        }
    }
}