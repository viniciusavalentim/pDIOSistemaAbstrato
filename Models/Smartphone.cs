using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pDIOSistemaAbstrato.Models
{
    public abstract class Smartphone
    {
        public string? Number { get; set; }
        private string? Model { get; set; }
        private string? IMEI { get; set; }
        private int Memory { get; set; }

        public Smartphone() {}
        public Smartphone(string? number, string? model, string? iMEI, int memory){
            Number = number;
            Model = model;
            IMEI = iMEI;
            Memory = memory;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallAPP(string nameAPP);

    }
}
