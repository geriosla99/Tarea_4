using System;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREA 4 Calculo de exponente
            //int exponente, numero, i = 1; 
            //double resultado = 1, resultadoNegativo;

            //Console.WriteLine("Ingresa la base:");
            //numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingresa el exponente:");
            //exponente = Convert.ToInt32(Console.ReadLine());

            //if (exponente < 0) //Si el exponente es negativo, entonces...
            //{
            //    exponente *= -1; // exponente = exponente * -1  ---> convierte el exponente a positivo

            //    for (i = 1; i <= exponente; i++) // Iteración desde 1 hasta llegar al exponente
            //    {
            //        resultado *= numero;
            //    }

            //    // Dividimos al 1 entre el resultado y se lo asignamos a una nueva variable
            //    resultadoNegativo = (1 / resultado);

            //    //Mostramos el resultado
            //    Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultadoNegativo);
            //}

            //else // Si el exponente no es menor que cero, por lo tanto es mayor o igual
            //{
            //    for (i = 1; i <= exponente; i++)
            //    {
            //        resultado *= numero;
            //    }

            //    //Mostramos el resultado
            //    Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
            //}

            //TAREA 4 Numeros primos

            int numero, divisor, numDivisores = 0;

            //Bucle exterior, se encarga de recorrer los números del 2 al 100
            for (numero = 2; numero <= 100; numero++)
            {
                //Bucle anidado, se encarga de verificar el número de divisores
                for (divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        numDivisores += 1; //numDivisores = numDivisores + 1;
                    }
                }

                //Verificamos que el número de divisiores sea igual a 2
                if (numDivisores <= 2)
                {
                    Console.WriteLine(numero);
                }

                //Reiniciamos el conteo del número de divisores
                numDivisores = 0;
            }

            Console.ReadKey();
        }
    }
}
