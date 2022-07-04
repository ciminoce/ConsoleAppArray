using System;
using System.Text;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros=new []{7,1,5,8,10};
            MostrarVector(numeros);
            var cantidad = numeros.Length;
            Console.WriteLine($"cantidad de elementos:{cantidad}");
            Console.WriteLine($"El array tiene {numeros.Rank} dimensión");
            Console.Write("Ingrese un número:");
            var numeroBuscado = int.Parse(Console.ReadLine());
            //bool existe = BuscarElemento(numeros, numeroBuscado);
            
            bool existe = Array.Exists(numeros, n => n == numeroBuscado);
            Console.WriteLine(existe?$"{numeroBuscado} está dentro del array":$"{numeroBuscado} no está dentro del array");
            var index=Array.IndexOf(numeros, numeroBuscado);
            Console.WriteLine(index>=0?$"{numeroBuscado} está en la posición {index}":$"{numeroBuscado} no se encuentra en el array");
            MostrarVectorEnLine(numeros);
            //Array.Clear(numeros,3,2);
            //MostrarVectorEnLine(numeros);
            Array.Sort(numeros);
            Array.Reverse(numeros);



            MostrarVectorEnLine(numeros);
            Console.ReadLine();
        }

        private static void MostrarVectorEnLine(int[] numeros)
        {
            StringBuilder sb=new StringBuilder();
            foreach (var numero in numeros)
            {
                sb.Append($"{numero} ");
            }

            Console.WriteLine(sb.ToString());
        }

        private static bool BuscarElemento(int[] numeros, int numeroBuscado)
        {
            foreach (var numero in numeros)
            {
                if (numeroBuscado==numero)
                {
                    return true;
                }
            }

            return false;
        }

        private static void MostrarVector(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
