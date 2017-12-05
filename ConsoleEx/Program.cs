using System;
using ConsoleEx.ExCSharpReview;
using ConsoleEx.QuestaoRevisao;

namespace ConsoleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Review r = new Review();
            int n;
            double valor;
            Conta conta = new Conta("José", "000.000.000-00", "0000-0", 121);
            while(true){
                Console.WriteLine("Para Realizar um depósito, digite 1");
                Console.WriteLine("Para realizar um saque, digite 2");
                Console.WriteLine("Para obter o extrato, digite 3");
                n = Convert.ToInt32(Console.ReadLine());
                if(n==1){
                    Console.WriteLine("Digite um valor");
                    valor = Convert.ToInt32(Console.ReadLine());
                    conta.depositar(valor);
                }else if(n==2){
                    Console.WriteLine("Digite um valor");
                    valor = Convert.ToInt32(Console.ReadLine());
                    conta.sacar(valor);
                }else{
                    conta.tirarExtrato();
                }
            }
         }
    }
}
