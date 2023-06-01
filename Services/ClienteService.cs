using Practica_23CV_24_MAY_23.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_23CV_24_MAY_23.Services
{
    public class ClienteService
    {

      public Cliente AgregarDatos()
        {
            try
            {
                Cliente DatosCliente = new Cliente();
                {
                    Console.WriteLine("Ingresa nombre: ");
                    DatosCliente.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa Telefono: ");
                    DatosCliente.Telefono = Console.ReadLine();
                    Console.WriteLine("Ingresa correo: ");
                    DatosCliente.Correo = Console.ReadLine();

                    Console.Clear();

                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Tus datos son: ");
                    Console.WriteLine("Nombre: " + DatosCliente.Nombre);
                    Console.WriteLine("Telefono: " + DatosCliente.Telefono);
                    Console.WriteLine("Correo: " + DatosCliente.Correo);
                    Console.WriteLine("------------------------------");
                }
                return DatosCliente;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error. " + ex.Message);
            }

        }
   
        public void NumerosYFunciones()
        {
            try
            {
                int num1, num2, num3, num4, num5, ResultSuma;
                Console.WriteLine("Ingresa el primer numero:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo numero:");
                num2= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer numero:");
                num3= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el cuarto numero:");
                num4= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el quinto numero:");
                num5 = int.Parse(Console.ReadLine());

                ResultSuma = num1 + num2 + num3 + num4 + num5;
                Console.WriteLine("La suma de los numeros ingresados es: " + ResultSuma);
                Console.WriteLine("-----------------------------------------------------");

                if (ResultSuma >= 5000 && ResultSuma < 8000) 
                {
                    double Descuento = ResultSuma * 0.10;
                    Console.WriteLine("El descuento del 10% es: " + Descuento);
                   
                }
                if (ResultSuma >= 8000 && ResultSuma < 10000)
                {
                    double TresMeses = ResultSuma / 3;
                    Console.WriteLine("Se le cobra en tres meses sin intereses, por lo cual son " + TresMeses + " por mes.");

                }
                if (ResultSuma >= 10000)
                {
                    Console.WriteLine("Se le quiere cobrar en 3 MESES o 6 MESES?");
                    int CantidadMeses = int.Parse(Console.ReadLine());

                    switch (CantidadMeses)
                    {
                        case 3:
                            double TresM = ResultSuma / 3;
                            Console.WriteLine("En tres meses, se le cobra " + TresM + " por mes.");
                            break;

                        case 6:
                            double SeisM = ResultSuma / 6;
                            Console.WriteLine("En seis meses, se le cobra " + SeisM + " por mes.");
                            break;

                         default: 
                            Console.WriteLine("ERROR - Elige entre 3 o 6.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error. " + ex.Message);
            }
           
        }


    }
}
