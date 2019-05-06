using System;

namespace PARCIAL3_EJ2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] paises = { " Alemania", " Holanda", " Dinamarca" };
            string[] grupos = new string[4];
            int[,] boletos = new int[4,3];
            int sumaboletos = 0;
            int sum_boletos1 = 0;
            int sum_boletos2 = 0;
            int sum_boletos3 = 0;
            int sum_boletos4 = 0;

            for (int g = 0; g < 4; g++)
            {
                Console.WriteLine($"Ingrese el Nombre del grupo {g}");
                grupos[g] = Console.ReadLine();
            }

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine($"Ingrese los boletos de {grupos[f]} En {paises[c]}");
                    boletos[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 3; c++)
                {

                    sumaboletos = sumaboletos + boletos[f, c];
                    sum_boletos1 = sum_boletos1 + boletos[0, c];
                    sum_boletos2 = sum_boletos2 + boletos[1, c];
                    sum_boletos3 = sum_boletos3 + boletos[2, c];
                    sum_boletos4 = sum_boletos4 + boletos[3, c];

                }
            }
            if (sum_boletos1 < sum_boletos2 && sum_boletos1 < sum_boletos3 && sum_boletos1 < sum_boletos4)
            {
                Console.WriteLine($"El menor grupo con venta fue {grupos[0]} con una suma de {sum_boletos1}");
            }
            else
            {
                if (sum_boletos2 < sum_boletos1 && sum_boletos2 < sum_boletos3 && sum_boletos2 < sum_boletos4)
                {
                    Console.WriteLine($"El menor grupo con venta fue {grupos[1]} con una suma de {sum_boletos2}");
                }
                else
                {
                    if (sum_boletos3 < sum_boletos1 && sum_boletos3 < sum_boletos2 && sum_boletos3 < sum_boletos4)
                    {
                        Console.WriteLine($"El menor grupo con venta fue {grupos[2]} con una suma de {sum_boletos3}");
                    }
                    else
                        Console.WriteLine($"El menor grupo con venta fue {grupos[3]} con una suma de {sum_boletos4}");
                }
            }
        }
    }
}
