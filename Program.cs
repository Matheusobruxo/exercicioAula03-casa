using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula03__casa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string client1 = ("José");
            string client2 = ("Leonardo");

            int idade1 = 1,
             idade2 = 24,
             QCafe1 = 25,
             QCafe2 = 15,
             QCafetotal = QCafe1 + QCafe2, // Letra Q de Quantidade
             QCafeFaltante1 = 200 - QCafe1,
             QCafeFaltante2 = 200 - QCafe2;


            Boolean c1 = true,    // Letra c de condição
                    c2 = false;


            Console.WriteLine($"Aula 03 - Atividade com variáveis\n\n\n" +
                $"Olá!\n" +
                $"Bem-vindo ao sistema de usuários do Conradito\n" +
                $"\n----------------------------------------------------------------------\n" +
                $"Abaixo estão as informações dos usuários cadastrados no nosso sistema" +
                $"----- Lista de usuários:\n" +
                $"Nome:{client1}, idade:{idade1}.É cliente:{c1}\n" +
                $"Nome:{client2}, idade:{idade2}.É cliente:{c2}\n\n" +
                $"-------------------------- Quantidade de cafés --------------------------\n" +
                $"O cliente {client1} já tomou {QCafe1} cafés!\n" +
                $"O cliente {client2} já tomou {QCafe2} cafés!\n\n" +
                $"----------------------------- Soma de cafés -----------------------------\n" +
                $"Juntos, os cliente {client1} e {client2} tomaram {QCafetotal} cafés! \n\n" +
                $"---------------- Quantos cafés falta para chegar em 200? ----------------\n" +
                $"Faltam {QCafeFaltante1} para {client1}!\n" +
                $"Faltam {QCafeFaltante2} para {client2}!\n" +
                $"--------------------- Fim do sistema de consultas -----------------------\n" +
                $"------------------------ Obrigado e volte sempre ------------------------");


            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}

