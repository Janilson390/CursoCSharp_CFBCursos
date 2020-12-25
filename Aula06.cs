using System;

class Aula06{
    static void Main(){
        double PrecoUnitario, Lucro, ValorVenda;
        string NomeProduto;

        Console.Write("Digite o nome do produto ");
        NomeProduto = Console.ReadLine();

        Console.Write("Digite valor de compra ");
        PrecoUnitario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a margem de lucro ");
        Lucro = Convert.ToDouble(Console.ReadLine());

        ValorVenda = PrecoUnitario + (PrecoUnitario * Lucro);
        
        Console.WriteLine("...........Resultado Final.........");
        Console.WriteLine("Produto...................{0,10}", NomeProduto);
        Console.WriteLine("Valor de Compra...........{0,10:c}", PrecoUnitario);
        Console.WriteLine("Margem de Lucro...........{0,10:p}", Lucro);
        Console.WriteLine("Valor de Venda............{0,10:c}", ValorVenda);
        Console.ReadKey(); 
    }
}