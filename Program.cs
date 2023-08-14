using Estacionamentos.Models;

// Estacionamento estacionanento = new Estacionamento();
List<Estacionamento> estacionamento = new List<Estacionamento>();
DateTime hora = DateTime.Now;

Console.WriteLine("Seja Bem Vindo ao Sistema De Estacionamento");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine("Para que tenha uma excelencia experiencia ao usar o sistema, por favor informe os devido campos");
Thread.Sleep(3000);
Console.Clear();
Console.Write("O valor da hora: ");
decimal valornow = Convert.ToDecimal(Console.ReadLine());
Thread.Sleep(3000);
Console.Clear();

string situacion = "sair";

do{
    bool existVeiculosCadastrado =  estacionamento.Count() > 0;
    Console.WriteLine("Escolha a opção");
    Console.WriteLine("Cadastrar");
    Console.WriteLine("Finalizar Tempo");
    Console.WriteLine("Verificar");
    Console.WriteLine("Lista de Veiculos");
    Console.WriteLine("Sair");
    situacion = Console.ReadLine()!;
    Console.Clear();

    switch(situacion.ToLower()){
        case "cadastrar":
            Console.Write("Placa:");
            string placa = Console.ReadLine()!;
            Console.Write("Hora de entrada:");
            // string Horasentrada = Convert.ToString(hora.ToString("HH"));
            string Horasentrada = "18";
            estacionamento.Add(new Estacionamento(placa, Horasentrada, valornow));
            Console.Clear();
            break;

        case "verificar":
            if(existVeiculosCadastrado != true){
                Console.WriteLine("Não Existe Veiculo cadastrado");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
            Console.Write("Qual Placa queres verificar: ");
            string placaVerificar = Console.ReadLine()!;
            if(placaVerificar is not null && estacionamento.Exists(x => x.Placa == placaVerificar)){
                estacionamento.Find(x => x.Placa == placaVerificar).Veiculo();
            }else{
                Console.WriteLine("Placa não cadastrar ou incorreta");
            }
            Thread.Sleep(5000);
            Console.Clear();
            break;
        case "finalizar tempo":
        
            if(existVeiculosCadastrado != true){
                Console.WriteLine("Não Existe Veiculo cadastrado");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }

            Console.Write("Informe a Placa para o Incerramento: ");
            string placaInserramento = Console.ReadLine()!;

            if(placaInserramento is not null && estacionamento.Exists(x => x.Placa == placaInserramento)){

                estacionamento.Find(x => x.Placa == placaInserramento).InseramentoEstacionamento(Convert.ToString(hora.ToString("HH")));
                Console.Clear();
                estacionamento.Find(x => x.Placa == placaInserramento).Veiculo();
                Thread.Sleep(6000);
                Console.Clear();

            }else{
                Console.WriteLine("Placa não cadastrar ou incorreta");
                Thread.Sleep(3000);
                Console.Clear();
            }
            break;
        case "lista de veiculos":
            foreach(var item in estacionamento){
                item.Veiculo();
            };
            Thread.Sleep(5000);
            Console.Clear();
            break;
        default:
            if(situacion.ToLower() != "sair"){
                Console.WriteLine("Erro");
            }
            break;
    }

}while(situacion.ToLower() != "sair");

Console.WriteLine("Até uma proxima, muito obrigado!");
// proj.Placa = "ILM1125";
// proj.ValorHora = 10;
// proj.Horasentrada = "10";
// proj.Horassaida = "9";

// proj.Veiculo();