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

        public void A41()
        {
            bool Ok = false;
            string IngresoFecha;
            List<DateTime> Fechas = new List<DateTime>();
            string ingreso = "";
            do
            {
                do
                {
                    Console.WriteLine("Ingrese una fecha: ");
                    IngresoFecha = Console.ReadLine();

                    if (!DateTime.TryParse(IngresoFecha, out DateTime Salida_Fecha))
                    {
                        Console.WriteLine("Debe ingresar una fecha");
                    }
                    else
                    {
                        Fechas.Add(Salida_Fecha);
                        Ok = true;
                    }

                } while (!Ok);

                Console.WriteLine("Ingrese 0 para salir");
                ingreso = Console.ReadLine();

            } while (ingreso != "0");

            Fechas.Sort();

            foreach (DateTime F in Fechas)
            {
                Console.WriteLine(F);
            }
        }

        public void A43()
        {
            bool Ok = false;
            string IngresoNum;
            List<int> Nums = new List<int>();
            string ingreso = "";
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: ");
                    IngresoNum = Console.ReadLine();

                    if (!int.TryParse(IngresoNum, out int Salida_Num))
                    {
                        Console.WriteLine("Debe ingresar un entero");
                    }
                    else
                    {
                        Nums.Add(Salida_Num);
                        Ok = true;
                    }

                } while (!Ok);

                Console.WriteLine("Ingrese -1 para salir");
                ingreso = Console.ReadLine();

            } while (ingreso != "-1");

            Console.WriteLine($"El máximo es: {Nums.Max()}");
            Console.WriteLine($"El mínimo es: {Nums.Min()}");
            Console.WriteLine($"El promedio es: {Nums.Average()}");
            Console.WriteLine($"La suma es: {Nums.Sum()}");
        }
    }
}
