using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // IO: Input e Output, Entrada e Saída

namespace CSharp_Entrada_Saida_com_streams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
                {
                    // var linha = leitor.Read();                
                    // var linha = leitor.ReadToEnd();

                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                } 

            Console.ReadLine();
        }

    }
}
