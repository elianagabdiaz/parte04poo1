using System;

namespace ejercicioejemplo
{
    class encapsulamiento
    {
        internal class Animal
        {
            private string nombre;   
            private int edad;        

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public int Edad
            {
                get { return edad; }
                set
                {
                    if (value >= 0) edad = value;
                    else Console.WriteLine("La edad no puede ser negativa");
                }
            }

            public string Color { get; set; }

            public void Presentarse()
            {
                Console.WriteLine("Soy " + Nombre + ", tengo " + Edad + " años, color " + Color);
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("ENCAPSULAMIENTO");
            Animal a1 = new Animal();
            a1.Nombre = "Firulais";
            a1.Edad = 3;
            a1.Color = "Marrón";
            a1.Presentarse();

            a1.Edad = -5;       
            a1.Presentarse();

            Animal a2 = new Animal { Nombre = "Luna", Edad = 2, Color = "Blanco" };
            a2.Presentarse();

        }
    }
}