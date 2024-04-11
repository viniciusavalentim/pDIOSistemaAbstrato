using pDIOSistemaAbstrato.Models;
using System;

namespace pDIOSistemaAbstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone NOKIA: ");
            Smartphone nokia = new Nokia(number: "1234124", model: "Modelo 1", iMEI: "1111111", memory: 128);
            nokia.Ligar();
            nokia.InstallAPP("WhatsAPP");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone iPhone: ");
            Smartphone iphone = new Iphone(number: "1515", model: "Modelo 2", iMEI: "222222", memory: 512);
            iphone.ReceberLigacao();
            iphone.InstallAPP("Linkeidn");

        }
    }
}