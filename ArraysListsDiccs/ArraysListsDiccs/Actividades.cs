using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsDiccs
{
    class Actividades
    {
        public void A39()
        {
            bool IngresoCorrecto = false;
            int[] ArrayIngreso = new int[5];

            do
            {
                for (int i = 0; i < ArrayIngreso.Length; i++)
                {
                    IngresoCorrecto = false;
                    while (!IngresoCorrecto)
                    {
                        Console.Write("Ingrese un número en la posición {0} ", i + 1);
                        string Ingreso = Console.ReadLine();
                        bool ok = !int.TryParse(Ingreso, out ArrayIngreso[i]);
                        if (ok)
                        {
                            Console.WriteLine("Debe ingresar valores numéricos");
                        }
                        else
                        {
                            IngresoCorrecto = true;
                        }
                    }
                }

            } while (!IngresoCorrecto);

            Array.Reverse(ArrayIngreso, 0, 5);

            foreach (int i in ArrayIngreso)
            {
                Console.Write(i + " ");
            }
        }

        public void A40()
        {
            bool Ok = false;
            string Ingreso;
           
            do
                {
                Console.WriteLine("Ingrese una frase: ");
                Ingreso = Console.ReadLine();

                Ok = !string.IsNullOrEmpty(Ingreso);
                if(!Ok)
                {
                    Console.WriteLine("Debe ingresar una frase");
                }
                
            } while (!Ok);

            string[] Palabras = Ingreso.Split(' ');
            foreach(string i in Palabras)
            {
                Console.WriteLine(i);
            }
        }
    }
}
