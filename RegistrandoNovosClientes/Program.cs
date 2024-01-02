using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program{
    static void Main(string[] args){
        //Lista de Clientes
        List<string> clientes = new List<string>();

        while(true){

            Console.WriteLine("Nome do Cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Email do Cliente: ");
            string email = Console.ReadLine();
            
            Console.WriteLine("Telefone do Cliente: ");
            string telefone = Console.ReadLine();

            //String geral que irá armazenar os dados 
            string clientInfo = $"{nome}, {email}, {telefone}";

            //Adicionando à Lista              
            clientes.Add(clientInfo);

            Console.WriteLine("Deseja continuar? S/N");
            string continuar = Console.ReadLine();

            if(continuar == "S"){
                continue;
            }else{
                break;
            }
            
        }
        foreach(string cliente in clientes){
            Console.WriteLine(cliente);
        }
    }
}