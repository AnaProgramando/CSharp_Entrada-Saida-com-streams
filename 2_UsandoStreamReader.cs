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
        static void UsarStreamReader()          
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
                        var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var mensagem = $"{contaCorrente.Titular.Nome} - Conta número {contaCorrente.Numero}, agência {contaCorrente.Agencia}. Saldo: R$ {contaCorrente.Saldo}";
                    Console.WriteLine(mensagem);    

                    // Console.WriteLine(linha);
                    }
                }

            Console.ReadLine();
        }
        

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ','); // Trocando o ponto do saldo pela vírgula
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);

            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
