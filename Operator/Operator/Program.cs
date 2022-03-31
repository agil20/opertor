using Operator.Models;
using System;

namespace Operator
{
    public enum Currecly { Dollar=1, Euro, Lire }
    internal class Program
    {
        static void Main(string[] args)
        {
            //{ Selsi selsi = new Selsi(100);
            //    Kelvin kelvin = selsi;
            //    Console.WriteLine(kelvin.Degre);
            Console.WriteLine("zehmet olmasa azn daxil edin");
            double azn=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Exchange(Currecly.Dollar,azn));


        }
        public static double Exchange(Enum obj, double azn)
        {
            if (obj is Enum)
            {
                switch (obj)
                {
                    case Currecly.Dollar:
                        {
                            azn = azn / 1.7;
                            break;
                        }
                    case Currecly.Lire:
                        {
                            azn = azn * 8;
                            break;
                        }
                    case Currecly.Euro:
                        {
                            azn = azn / 2;
                            break;
                        }

                }


            }
            else
            {
                Console.WriteLine("obj enumda yoxdu");
            }
            return azn;

        }


    }

}
/*2. Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var
 * ve Degree adli property-leri var.
 * Celcius uchun implicit operatorunu yazmaginizi isteyirem.(0C=273K)*/
