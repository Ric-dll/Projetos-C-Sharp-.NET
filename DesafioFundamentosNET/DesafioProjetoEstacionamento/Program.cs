using System.Globalization;
using DesafioProjetoEstacionamento.Models;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Definição de variáveis necessárias

bool Menu = true; //Define como verdadeiro para inicio quando for chamado no laço
String opcaoMenu = string.Empty; //Define a string opcaoMenu com um valor vazio

//Fim da definição definição de variáveis necessárias


Console.WriteLine("_______[ Controle de Estacionamento ]_______");

    Console.WriteLine("Para iniciar, defina um preço inicial: ");
    decimal definicaoPrecoInicial = Convert.ToDecimal(Console.ReadLine());
    /*Aqui usamos a função Convert.ToDecimal antes de usar a função ReadLine, pois como a função
    recebe sempre uma String, ela será formatada para tipo decimal*/  

    Console.WriteLine("Agora, defina o preço por hora: ");
    decimal definicaoPrecoPorHora = Convert.ToDecimal(Console.ReadLine());
    
    //precoInicial e precoPorHora recebe a conversão para decimal do que o usuário digitar


//Agora Instanciando a classe Estacionamento, com os valores obtidos anteriormente
Estacionamento estacionamento = new Estacionamento(definicaoPrecoInicial, definicaoPrecoPorHora);

while(Menu){
    Console.Clear();//Limpa o que já foi exibido

    //Menu de Opções
    Console.WriteLine("___[ Controle de Estacionamento ]___");
    Console.WriteLine("\n1. Cadastrar Veículo" + "\n2. Remover Veículo" + "\n3. Listar Veículos" + "\n4. Sair do programa \n\nOpção: ");

    //De forma direta, espera a opção de entrada do usuário
    switch(Console.ReadLine()){
        case "1":
            //Chama a função Para adicionar o veículo
            estacionamento.AdicionarVeiculo();
        break;

        case "2":
            //Chama a função Para Remover o veículo
            estacionamento.RemoverVeiculo();
        break;

        case "3":
            //Chama a função Para Listar Todos os veículos
            estacionamento.ListarVeiculosEstacionados();
        break;

        case "4":
            //Define menu como falso para encerrar o loop
            Menu = false;
        break;

        default:
            Console.WriteLine("Opção Inválida, Tente Novamente!...");
        break;
    }
    Console.WriteLine($"Pressione Qualquer tecla para continuar...{Console.ReadLine()}");
}

Console.WriteLine("Programa Encerrado...");