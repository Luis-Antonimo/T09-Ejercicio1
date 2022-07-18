using System;

namespace T09Ejercicio1
{
    class Program
    {

        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.ImprimeDatos();
            alumno1.MayorEdad();
        }

        class Alumno
        {
            private int edad;
            private string nombre;

            public Alumno()
            {
                Console.WriteLine("Escriba el nombre del alumno.");
                nombre = Console.ReadLine();
                Console.WriteLine("Escriba la edad del alumno.");
                edad = Convert.ToInt32(Console.ReadLine());

            }

            public void ImprimeDatos()
            {
                Console.WriteLine("El alumno " + nombre + " tiene " + edad + " años.");
            }

            public void MayorEdad()
            {
                if (edad < 18)
                {
                    Console.WriteLine("El alumno " + nombre + " es menor de edad.");
                }
                else
                {
                    Console.WriteLine("El alumno " + nombre + " es mayor de edad.");
                }
            }
        }
    }
}