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
                intentos++;
                if (numeroUsuario < numeroAleatorio && numeroUsuario > 1)
                {
                    Console.WriteLine("Intenta de nuevo con un número más grande");
                }
                else if (numeroUsuario > numeroAleatorio && numeroUsuario < 100)
                {
                    Console.WriteLine("Intenta de nuevo con un número más pequeño");
                }
                else if (numeroUsuario < 1)
                {
                    Console.WriteLine("Has introducido un número menor que 1, intenta de nuevo");
                }
                else if (numeroUsuario > 100)
                {
                    Console.WriteLine("Has introducido un número mayor que 100, intenta de nuevo");
                }
                numeroUsuario = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Lo has conseguido al {intentos} intento.");
        }
    }
}
