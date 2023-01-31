using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSemana3.clases
{
    public class Celular
    {
        private string marca;

        //Atributos
        public string Marca { get
            {
                if (marca == null)
                {
                    marca = "Samsung";
                }
                return marca;
            } set => marca = value;  
        }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //Constructores

        public Celular() { }
        public Celular(string marca,string modelo,string color) 
        { 
        this.Marca = marca;
        this.Modelo = modelo;
        this.Color = color;
        }
        public Celular(string modelo, string color)
        {
            this.Modelo = modelo;
            this.Color = color;
        }

        //Metodos

        public void llamar(string nombre)
        {
            Console.WriteLine("Lammando a..."+ nombre);
            Console.WriteLine($"Llamando a {nombre}"); //interpolacion
            Console.WriteLine("Llamando a {0}", nombre); //Template String
           
        }

        public void finalizarLlamada()
        {
        Console.WriteLine("Llamada finalizada...");
        }

        public override string ToString()
        {
            string info = $"Marca: {Marca} | Modelo: {Modelo} | Color: {Color}";
    

            return info;
        }
   

    }
}
