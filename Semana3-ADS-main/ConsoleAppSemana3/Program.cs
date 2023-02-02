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

            Electronico miElectronico = new Electronico();
            miElectronico.Marca = "Apple";
            miElectronico.Modelo = "iPhone 14";
            miElectronico.Color = "Rojo";

            miElectronico.llamar("Juan");
            miElectronico.finalizarLlamada();

           
            Console.WriteLine(miElectronico.ToString());
           

            Electronico otroElectronico = new Electronico("Honor", "Honor Pro", "Negro");
            Console.WriteLine(otroElectronico.ToString());

            Electronico Electronico3 = new Electronico("Cualquier", "Verde");
            Console.WriteLine(Electronico3.ToString());

            Electronico Electronico4 = new Electronico("Iphone", "Iphone 13", "Verde");
            Console.WriteLine(Electronico4.ToString());

            Console.WriteLine("***************************");
            SmartPhone smartPhone = new SmartPhone("Z flot", "Samsung", "Negro", 180F, 64F);
            Console.WriteLine(smartPhone.ToString());

            smartPhone.llamar("eso");
            smartPhone.finalizarLlamada();

            Console.ReadKey();
        }
    }
}
