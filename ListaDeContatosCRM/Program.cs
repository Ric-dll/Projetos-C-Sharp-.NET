using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program{
    static void Main(string[] args){
        
        //Definindo o tamanho da lista de clientes
        int tamanhoLista = int.Parse(Console.ReadLine());
        
        //Criando lista
        List<string> listaClientes = new List<string>();
    
        //Adicionando a quantidade de clientes a lista
        for(int i=0; i<tamanhoLista; i++){
            Console.WriteLine("Contato, Nome: ");
            string nome = Console.ReadLine();
            listaClientes.Add(nome);
        }

        Console.WriteLine("Lista de Contatos:");

        for(int i=0; i<listaClientes.Count; i++){
            Console.WriteLine($"{i+1}. {listaClientes[i]}");
        }
    }
}