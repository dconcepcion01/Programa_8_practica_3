using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_8_practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre_empleado;
            double sueldo, isr=0, ars, afp=2.87, resultado;

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("ESTE PROGRAMA TE CALCULA LAS DEDUCIONES DE IMPUESTO POR LAS INSTITUCIONES");

            Console.SetCursorPosition(5, 9);
            Console.WriteLine("Digite el nombre del empleado:");
            Console.SetCursorPosition(5, 10);
            Nombre_empleado = Console.ReadLine();

            Console.SetCursorPosition(5, 11);
            Console.WriteLine("Digite el sueldo del empleado:");
            Console.SetCursorPosition(5, 12);
            sueldo = Convert.ToDouble(Console.ReadLine());

            //Console.SetCursorPosition(5, 13);
            //Console.WriteLine("Digite el isr aplicar:");
            //Console.SetCursorPosition(5, 14);
            //isr = Convert.ToDouble(Console.ReadLine());

            

            Console.SetCursorPosition(5, 13);
            Console.WriteLine("Digite ars aplicar:");
            Console.SetCursorPosition(5, 15);
            ars = Convert.ToDouble(Console.ReadLine());

            //Console.SetCursorPosition(5, 21);
            //Console.WriteLine("Digite afp aplicar (2.87%) :");
            //Console.SetCursorPosition(5, 23);
            //afp = Convert.ToDouble(Console.ReadLine());

            Console.SetCursorPosition(5, 19);
            if (isr <= 399923.00)
            {
                Console.WriteLine("Esta exenta del pago de  impuesto sobre renta");
            }
            else if (isr <= 599884.00 * 15)
            {
                Console.WriteLine("Paga por ley un 15%");
            }
            else if (isr <= 833171.00 * 20)
            {
                Console.WriteLine("Paga por ley segun monto un 20% de Impuesto sobre la renta");

            }
            else if (isr >= 833171.01 * 25)
            {
                Console.WriteLine("Paga por ley segun monto un  25% de Impuesto sobre la renta");

            }
            resultado = sueldo - isr*100% - ars*100% - afp *100;
            Console.SetCursorPosition(5, 25);
            Console.WriteLine("Aplicado un impuesto fijo de afp=2.87");
            Console.SetCursorPosition(5, 27);
            Console.WriteLine("El resultado del empleado  : " + Nombre_empleado   +   "  =  "  +  resultado);

           


            Console.ReadLine();


        }
        
    }
}
