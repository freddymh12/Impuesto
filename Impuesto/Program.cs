using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tipo de producto (medicina, otro):");
            string tipoProducto = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese el precio del producto:");
            double precioProducto = Convert.ToDouble(Console.ReadLine());

            double impuesto = CalcularImpuesto(tipoProducto, precioProducto);
            double precio = precioProducto + impuesto;
            Console.WriteLine($"El impuesto a pagar es: {impuesto:C}");
            Console.WriteLine($"El precio total es: {precio:C}");
            Console.ReadKey();
        }

        static double CalcularImpuesto(string tipoProducto, double precio)
        {
            const double impuestoMedicina = 0.0;
            const double impuestoOtro = 0.16;

            double porcentajeImpuesto = tipoProducto == "medicina" ? impuestoMedicina : impuestoOtro;

            return precio * porcentajeImpuesto;
        }
    }
    }
