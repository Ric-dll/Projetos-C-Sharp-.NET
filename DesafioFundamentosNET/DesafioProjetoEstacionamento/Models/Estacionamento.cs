using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoEstacionamento.Models
{
    public class Estacionamento{ 
        //Criando dois atributos privados para preço e a lista de veículos
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        
        //Construtor que contém dois parâmetros
        public Estacionamento(decimal parPrecoInicial, decimal parPrecoPorHora){
            this.precoInicial = parPrecoInicial;
            this.precoPorHora = parPrecoPorHora;
        }

        //Métodos do programa
        public void AdicionarVeiculo(){
            //Recebendo e adicionando na lista
            Console.WriteLine("Digite a Placa do Veículo para estacionar: ");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine($"Veículo adicionado com Sucesso!");
        }

        public void RemoverVeiculo(){
            //Pedindo ao usuário as informações
            Console.WriteLine("Digite a Placa do Veículo para Remove-lô: ");
            string placa = Console.ReadLine(); //Variável placa inicializada com valor dado pelo usuário

            //Verificando se o veículo existe...
            //A função Any retorna true se pelo menos um elemento na coleção satisfizer a condição especificada...
            //Não é nesessário declarar de forma antecipada a variável item nesse contexto de lambda
            //Item => item.ToUpper() significa que a variável item vai receber cada placa toando-a maiuscula e comparando com a placa digitada
            if(veiculos.Any(item => item.ToUpper() == placa.ToUpper())){//Se sim
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no local: ");

                //Recebe as horas e converte para inteiro para realizar o calculo do valor de pagamento
                int horas = Convert.ToUInt16(Console.ReadLine());

                //Remove a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O Veículo de placa: {placa} foi removido, Valor total a ser pago: {precoInicial + precoPorHora * horas:C}");
            }else{
                Console.WriteLine($"Veículo não encontrado. Verifique se a Placa foi digitada corretamente, Placa: {placa}");
            }
        }
    
        public void ListarVeiculosEstacionados(){
            //Verifica se há veículos no estacionamento
            if(veiculos.Any()){
                Console.WriteLine("Os veículos estacionados são: \n");
                for(int i=0; i<veiculos.Count; i++){
                    Console.WriteLine($"[{i+1}] - {veiculos[i]}");
                }
            }else{
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
