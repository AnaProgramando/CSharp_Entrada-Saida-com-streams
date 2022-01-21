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
            CriarAquivoComWriter();
            Console.WriteLine("Aplicação finalizada.");

            Console.ReadLine();
        }
    }
}
