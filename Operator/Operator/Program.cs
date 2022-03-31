using Operator.Models;
using System;

namespace Operator
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            //{ Selsi selsi = new Selsi(100);
            //    Kelvin kelvin = selsi;
            //    Console.WriteLine(kelvin.Degre);
            Console.WriteLine("Please add azn : ");
            double azn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.azn cevir euro\n" +
                "2. azn cevir lire\n" +
                "3. azn cevir dollar");
           
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine(Exchange(Currecly.Euro, azn));
                    break;
                case 2: Console.WriteLine(Exchange(Currecly.Lire,azn)); break;
                case 3: Console.WriteLine(Exchange(Currecly.Dollar,azn)); break;
            }


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
    public enum Currecly { Dollar = 1, Euro, Lire }
}
/*2. Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var
 * ve Degree adli property-leri var.
 * Celcius uchun implicit operatorunu yazmaginizi isteyirem.(0C=273K)*/
