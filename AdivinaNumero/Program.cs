using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeros = new Random();
            int numeroAleatorio = numeros.Next(0, 100);
            Console.WriteLine("Adivina el número que está entre el 1 y el 100.");
            Console.WriteLine("Introduce el numero.");
            int numeroUsuario = int.Parse(Console.ReadLine());
            int intentos = 1;
            while (numeroUsuario != numeroAleatorio)
            {
                if (numeroUsuario < numeroAleatorio && numeroUsuario > 1)
                {
                    Console.WriteLine("Intenta de nuevo con un número más grande");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    intentos++;
                }
                else if (numeroUsuario > numeroAleatorio && numeroUsuario < 100)
                {
                    Console.WriteLine("Intenta de nuevo con un número más pequeño");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    intentos++;
                }
                else if (numeroUsuario < 1)
                {
                    Console.WriteLine("Has introducido un número menor que 1, intenta de nuevo");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    intentos++;
                }
                else if (numeroUsuario > 100)
                {
                    Console.WriteLine("Has introducido un número mayor que 100, intenta de nuevo");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    intentos++;
                }
            }
            Console.WriteLine($"Lo has conseguido al {intentos} intento.");
        }
    }
}
