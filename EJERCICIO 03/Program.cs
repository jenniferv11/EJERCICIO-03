using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, adivinanza;
            float pago;

            Console.Write("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de adivinanzas acertadas: ");
            adivinanza = int.Parse(Console.ReadLine());

            pago = 0f;

            if (edad > 18)
            {
                if (adivinanza < 3)
                {
                    pago = 30 + 5 * edad + 2 * adivinanza;
                }
                else
                {
                    pago = 50 + 5 * edad + 2 * adivinanza;
                }
                Console.WriteLine("El monto final del premio sera: /$" + pago);
            }
            else if (edad < 18)
            {
                if (adivinanza > 3)
                {
                    pago = 50 + 5 * edad + 2 * adivinanza;
                }
                else
                {
                    pago = 50 + 5 * edad + 2 * adivinanza;
                }
            }
            Console.ReadKey();
        }
    }
}
