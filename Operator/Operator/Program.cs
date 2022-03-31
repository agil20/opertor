using System;

namespace Operator
{
    public enum Currecly { Dollar, Euro, Lire }
    internal class Program
    {
        static void Main(string[] args)

        {

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

