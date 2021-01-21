using System;
class Aula16{
    enum Veiculos{Carro, Aviao, Navio, Indefinido};
    static void Main()
    {
        char Opcao = ' ';
        double TempoViagem;
        Veiculos Veiculo;

        Inicio:
        //Console.Clear();

        Console.WriteLine("Informe o veiculo que deseja viagar!\n([c]Carro\t[a]Aviao\t[n]Navio)");
        Opcao = (char)Console.Read();

        switch(Opcao){
            case 'c':
            case 'C':
                TempoViagem = 60;
                Veiculo = Veiculos.Carro;
                break;
            case 'a':
            case 'A':
                TempoViagem = 5;
                Veiculo = Veiculos.Aviao;
                break;
            case 'n':
            case 'N':
                TempoViagem = 78;
                Veiculo = Veiculos.Navio;
                break;
            default :
                TempoViagem = 0;
                Veiculo = Veiculos.Indefinido;
                break;
        }
        
        Console.WriteLine("A sua viagen será de {0} e o tempo será de {1} horas. Aproveite!", Veiculo, TempoViagem);

        Console.WriteLine("");
        Console.WriteLine("Calcular Novamento?[s/n]");
        Opcao = char.Parse(Console.ReadLine());

        if(Opcao == 's' || Opcao == 'S')
        {
            goto Inicio;
        }else
        {
            //Console.Clear();
            Console.WriteLine("Fim do Programa!");
        }
    }   
}