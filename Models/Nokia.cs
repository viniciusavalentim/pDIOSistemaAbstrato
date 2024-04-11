using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pDIOSistemaAbstrato.Models
{
    public class Nokia : Smartphone
    {
        public Nokia()
        {
            
        }

        public Nokia(string? number, string? model, string? iMEI, int memory) : base(number, model, iMEI, memory)
        {
            Number = number;
        }

        public override void InstallAPP(string nameAPP)
        {
            Console.WriteLine($"Instalando o APP \"{nameAPP}\" no Nokia");
        }
    }
}
