using System;
using System.Runtime.CompilerServices;

class Program{
    static void Main(string[] args){
        //A variável recebe e converte para int diretamente o que for recebido
        Console.WriteLine("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        if(idade >= 18){
            Console.WriteLine("Seja bem-vindo!\nAcesso permitido ao CRM.");
        }else{
            Console.WriteLine("Acesso negado. Você não tem idade suficiente para acessar o CRM.");
        }
    }
}