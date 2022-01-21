using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Entrada_Saida_com_streams
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrenteTesteBinario.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(321); // Número da agência
                escritor.Write(13579); // Número da conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Ana Programando"); // Nome titular
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrenteTesteBinario.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Titular: {titular} | Agência: {agencia} | Conta: {numeroConta} | Saldo: R$ {saldo}");
            }
        }

    }
}
