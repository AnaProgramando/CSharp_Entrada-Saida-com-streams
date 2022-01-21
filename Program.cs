using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // IO: Input e Output, Entrada e Saída
using CSharp_Entrada_Saida_com_streams.Modelos;

namespace CSharp_Entrada_Saida_com_streams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //using (var fs = new FileStream("testaTipos.txt", FileMode.Create))
            //using (var escritor = new StreamWriter(fs))
            //{
            //    escritor.WriteLine(true);
            //    escritor.WriteLine(false);
            //    escritor.WriteLine(0987654321);
            //}

            LeituraBinaria();
            Console.WriteLine("Aplicação finalizada.");

            Console.ReadLine();
        }
    }
}
