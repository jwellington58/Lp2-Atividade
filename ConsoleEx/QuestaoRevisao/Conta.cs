using System;

namespace ConsoleEx.QuestaoRevisao
{
    public class Conta
    {
        public Conta(string usuario, string cpf, string numeroConta, int agencia){
            this.usuario = usuario;
            this.cpf = cpf;
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.saldo = 0;
            extrato  = new string[10];
            aux = 0;
        }
        private string usuario{get; set;}
        private string cpf{get; set;}
        private string numeroConta{get; set;}
        private int agencia{get; set;}
        private double saldo{get; set;}
        private string[] extrato;
        private string msg;
        private int aux;

        public double sacar(double valor){
            if(verifica(saldo)){
                this.saldo -= valor;
                msg = "Saque";
                extrato[aux] =  $"{msg} de {valor}";
                aux++;
                
               
            }return saldo;
        }
        public void depositar(double valor){
            this.saldo += valor;
            msg = "Deposito de ";
            extrato[aux] =  msg + Convert.ToString(valor);
            aux++;
        }
        public bool verifica(double valor){
            if(this.saldo >= valor){
                return true;
            }return false;
        }
        public void tirarExtrato(){
            for(int j = 0; j < aux; j++){
                Console.WriteLine(extrato[j]);
            }
        }
        
        

    }
}