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

            // ---------------------------------------------

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Criado o arquivo escrevendoComAClasseFile.txt!");
            Console.WriteLine("Pressione o Enter para continuar...");

            Console.ReadLine();

            // ---------------------------------------------

            // var todoTexto = File.WriteAllText("contas.txt");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"O arquivo contas.txt possui: {bytesArquivo.Length} bytes.");
            Console.WriteLine("Pressione o Enter para continuar...");

            Console.ReadLine();

            // ---------------------------------------------

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine($"Número de linhas do arquivo contas.txt: {linhas.Length}");

            Console.WriteLine("Pressione o Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("Pressione o Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------

            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine($"O nome digitado foi: {nome}");
            Console.WriteLine("Pressione o Enter para continuar...");
            Console.WriteLine(" ");

            Console.ReadLine();

            // ---------------------------------------------

            UsarStreamDeEntrada();
            Console.WriteLine("Aplicação finalizada.");

            Console.ReadLine();
        }
    }
}
