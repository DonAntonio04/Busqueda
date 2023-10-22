using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda
{
    internal class Busqueda
    {
        public void Lineal1()
        {
            int[] lineal = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int indice = -1;
            Console.WriteLine("Ingrese un valor del arreglo");
            int valor = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;  i < lineal.Length; i++)
            {
                if (lineal[i] == valor)
                {
                    indice = i;
                    break;
                }
            }
            if(indice != -1)
            {
                Console.WriteLine( $"El número se encuentra el la posición : {indice} ");
            }
            else
            {
                Console.WriteLine("El número no se encuentra");
            }
        }

        public void cadena()
        {
            string[] cadena = new string[5] { "Manzana", "Pera", "Plátano", "Fresa", "sandía" };
            int indice = -1;
            Console.WriteLine("Ingrese la cadena del arreglo (inicie con mayúsculas)");
            string cadenas = Console.ReadLine();

            for( int i = 0; i < cadena.Length;i++)
            {
                if (cadena[i] == cadenas)
                {
                    indice = i;
                    break;
                }
            }
            if(indice != -1)
            {
                Console.WriteLine($"La posición de la cadena en el arreglo es : {indice}");
            }
            else
            {
                Console.WriteLine("La cadena no se encuentra ");
            }
        }
        public void Pares()
        {
            int[] pares = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int indice = -1;

            for( int i = 0; i < pares.Length;i++)
            {
                if (pares[i] % 2  == 0 )
                {
                    Console.WriteLine(pares[i]);
                }
            }
        }

        public void Pares2()
        {
            int[] pares = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8 , 9, 10 };
            int indice = -1;

            for (int i = 0; i < pares.Length; i++)
            {

                if (pares[i] % 2 == 0)
                {
                    Console.WriteLine($"El número par {pares[i]} se encuentra en la posición {i} del arreglo.");
                }
            }
        }

        public void Binario()
        {
            int[] arreglo = new int [10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }; 

            Console.WriteLine("Ingrese el número a buscar: ");
            int objetivo = Convert.ToInt32(Console.ReadLine());


            // Inicializamos un índice izquierdo en 0
            int izquierda = 0;

            // Inicializamos un índice derecho al final del arreglo
            int derecha = arreglo.Length - 1;

            // Inicializamos la variable de posición en -1 
            int posicion = -1;

            while (izquierda <= derecha) // Comienza un bucle de búsqueda
            {
                int mitad = izquierda + (derecha - izquierda) / 2; // Calculamos el índice del medio

                if (arreglo[mitad] == objetivo) // Si encontramos el número objetivo
                {
                    posicion = mitad; // Almacenamos la posición y salimos del bucle
                    break;
                }

                else if (arreglo[mitad] < objetivo) // Si el número en el medio es menor que el objetivo 
                {
                    izquierda = mitad + 1; // Establecemos el nuevo índice izquierdo después del medio

                }
                else
                {
                    derecha = mitad - 1; // Si no, establecemos el nuevo índice derecho antes del medio

                }
            }

            if (posicion != -1) 
            {
                Console.WriteLine("El número {0} se encuentra en la posición {1}.", objetivo, posicion);
            }
               
            else
            {
                Console.WriteLine("El número {0} no se encuentra en el arreglo.", objetivo); 
            }
        }

        public void Cadena2()
        {
            string[] cadena = new string[5] { "Alonso", "Bartolo", "Carlos", "Daniel", "Ernesto" };

            Console.WriteLine("Ingrese la cadena");
            string objetivo = Console.ReadLine();

            int izquierda = 0;
            int derecha = cadena.Length - 1;
            int posicion = -1;

            while (izquierda <= derecha)
            {
                int mitad = izquierda + (derecha - izquierda) / 2;

                int comparacion = string.Compare(cadena[mitad], objetivo);

                if (comparacion == 0)
                {
                    posicion = mitad;
                    break;
                }

                if (comparacion < 0) 
                {
                    izquierda = mitad + 1;

                }
                else
                {
                    derecha = mitad - 1;

                }
            }

            if (posicion != -1)
            {
                Console.WriteLine("La cadena '{0}' se encuentra en la posición {1}.", objetivo, posicion);
            }
            
            else
            {
                Console.WriteLine("La cadena '{0}' no se encuentra en el arreglo.", objetivo);

            }
        }

        public void Par3()
        {
            int[] arreglo = { 2, 2, 4, 6, 8, 10, 11, 13, 15 }; // Arreglo ordenado de ejemplo
            int izquierda = 0;
            int derecha = arreglo.Length - 1;
            int resultado = -1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arreglo[medio] % 2 == 0)
                {
                    resultado = medio;
                    derecha = medio - 1; // Continuar buscando en la mitad izquierda
                }
                else
                {
                    izquierda = medio + 1; // Continuar buscando en la mitad derecha
                }
            }

            if (resultado != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {resultado}: {arreglo[resultado]}");
            }
            else
            {
                Console.WriteLine("No se encontró ningún número par en el arreglo.");
            }
        }
    } 
    
}

