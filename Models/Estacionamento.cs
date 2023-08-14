using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamentos.Models
{
    public class Estacionamento{

        public string Placa {get;set;} = default!;
        public string Horasentrada {get;set;} = default!;
        public string Horassaida {get;set;} = default!;
        public decimal ValorHora {get;set;}

    public Estacionamento(string placa1, string horadeentrada, decimal valorHoraNow){
        this.Placa = placa1;
        this.Horasentrada = horadeentrada;
        this.ValorHora = valorHoraNow;
    }

    public void InseramentoEstacionamento(string horadesaida){
        this.Horassaida = horadesaida;
    }
        public void Veiculo(){
            Console.WriteLine($"Veiculo com a Placa:{Placa}");
            Console.WriteLine($"Estacionou as {Horasentrada}H");
            if(Convert.ToInt32(Horassaida) != 0){
                Console.WriteLine($"Esta saindo as {Horassaida}H");
                decimal dados = ValorHora / 60;
                decimal horas =  Convert.ToDecimal(Horassaida) - Convert.ToDecimal(Horasentrada);
                decimal valor = horas * ValorHora;
                Console.WriteLine($"O valor total ficou de R${valor}");
            }else{
                Console.WriteLine("Ainda se encontra estacionado");
            }
            
        }

        public bool existPlaca(string dice = default!){
            if(this.Placa == dice){
                return true;
            }else{
                return false;
            }
        }

    }
}