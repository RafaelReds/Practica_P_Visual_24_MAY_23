using Practica_23CV_24_MAY_23.Entities;
using Practica_23CV_24_MAY_23.Services;
using System;

namespace Practica_23CV_24_MAY_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa:
            //Pide datos del cliente. (Nombre, Telefono y Correo)
            //Pedir 5 numeros (Articulos) y el total de la suma de esos numeros.
            //Si el total es mayor/igual a 5000, se le hace DESCUENTO del 10%
            //Si es mayor/igual a 8000, se le cobra en 3 MESES SIN INTERESES
            //Si es mayor/igual a 10000, se le cobra en 3 MESES o 6 MESES

           ClienteService AgregarDatos = new ClienteService();
            AgregarDatos.AgregarDatos();

            ClienteService Funciones = new ClienteService();
            Funciones.NumerosYFunciones();
            
            
        }
    }
}
