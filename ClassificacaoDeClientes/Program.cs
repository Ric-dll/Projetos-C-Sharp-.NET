using System;
using System.Runtime.CompilerServices;
//using Internal;

class Program{
    static void Main(string[] args){
        
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine();
        double valorTotalCompras = double.Parse(Console.ReadLine());

        string categoria;

            if(valorTotalCompras >= 500){
                categoria = "CLIENTE";
            }else{
                categoria = "LEAD";
            }

        Console.WriteLine($"{nome} foi classificado(a) como {categoria}");
    }
}