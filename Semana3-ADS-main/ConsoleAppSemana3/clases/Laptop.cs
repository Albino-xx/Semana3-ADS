using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSemana3.clases
{
    public class Laptop : Electronico
    {
        public float Procesador { get; set; }
        public float MemoriaRAM { get; set; }

        public Laptop() { }

        public Laptop(string modelo, string marca, string color, float procesador, float memoriaram) : base(marca, modelo, color)
        {
            this.Procesador = procesador;
            this.MemoriaRAM = memoriaram;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | MemoriaRam {MemoriaRAM} | Procesador {Procesador}";
        }

    }
}
