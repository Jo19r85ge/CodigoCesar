using System;


namespace CodigoCesar
{
    class Program
    {

        public static char Cifrar(char texto, int desplazamientos)
        {
            if (!char.IsLetter(texto))
            {

                return texto;
            }

            char palabra = char.IsUpper(texto) ? 'A' : 'a';
            return (char)((((texto + desplazamientos) - palabra) % 26) + palabra);

        }


        public static string Encriptar(string input, int desplazamientos)
        {
            string output = string.Empty;

            foreach (char texto in input)

                output += Cifrar(texto, desplazamientos);

            return output;
        }

        public static string Descriptar(string input, int desplazamientos)
        {
            return Encriptar(input, 26 - desplazamientos);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el texto para encriptar:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Numero de desplazamientos:");
            int desplazamientos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Texto encriptado:");

            string textoCifrar = Encriptar(UserString, desplazamientos);
            Console.WriteLine(textoCifrar);

            Console.Write("\n");

            Console.WriteLine("Texto descriptado:");

            string textoDescriptar = Descriptar(textoCifrar, desplazamientos);
            Console.WriteLine(textoDescriptar);

            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
