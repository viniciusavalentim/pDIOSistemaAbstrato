using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pDIOSistemaAbstrato.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string? number, string? model, string? iMEI, int memory) : base(number, model, iMEI, memory)
        {
            Number = number;
        }

        public override void InstallAPP(string nameAPP)
        {
            Console.WriteLine($"Instalando o APP \"{nameAPP}\" no iPhone");
        }
    }
}
