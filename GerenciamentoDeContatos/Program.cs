using System;
using System.Runtime.CompilerServices;

class Program{
    static void Main(string[] args){
        while(true){
            //Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            //Console.WriteLine("Email:");
            string email = Console.ReadLine();
            
            //Console.WriteLine("Tell:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Contato adicionado!");
            Console.WriteLine($"Nome: {nome} \nE-mail: {email} \nTell: {telefone}");
            break;
        }
    }
}