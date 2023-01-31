using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSemana3.clases
{
    public class SmartPhone : Celular
    {
        public float PixelesCam { get; set; }
        public float Memoria { get; set; }

        public SmartPhone() { }

        public SmartPhone(string modelo, string marca, string color, float pixelesCam, float memoria) : base(marca, modelo, color)
        {
            this.PixelesCam = pixelesCam;
            this.Memoria = memoria;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Memoria {Memoria} | Pixeles {PixelesCam}";
        }

    }
}
