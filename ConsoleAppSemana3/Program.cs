using ConsoleAppSemana3.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSemana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************POO**************");

            Celular miCelular = new Celular();
            miCelular.Marca = "Apple";
            miCelular.Modelo = "iPhone 14";
            miCelular.Color = "Rojo";

            miCelular.llamar("Juan");
            miCelular.finalizarLlamada();

           
            Console.WriteLine(miCelular.ToString());
           

            Celular otroCelular = new Celular("Honor", "Honor Pro", "Negro");
            Console.WriteLine(otroCelular.ToString());

            Celular Celular3 = new Celular("Cualquier", "Verde");
            Console.WriteLine(Celular3.ToString());

            Celular Celular4 = new Celular("Iphone", "Iphone 13", "Verde");
            Console.WriteLine(Celular4.ToString());

            Console.WriteLine("***************************");
            SmartPhone smartPhone = new SmartPhone("Z flot", "Samsung", "Negro", 180F, 64F);
            Console.WriteLine(smartPhone.ToString());

            smartPhone.llamar("eso");
            smartPhone.finalizarLlamada();

            Console.ReadKey();
        }
    }
}
