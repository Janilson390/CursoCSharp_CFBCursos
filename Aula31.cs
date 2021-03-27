using System;

static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public int numero = 0;

    static public void Iniciar(){
        numero++;
        nome = "Jogador nº "+ numero.ToString();
        energia = 100;
        vivo = true;
    }

    static public void Iniciar(string n){
        
        nome = n;
        energia = 100;
        vivo = true;
    }

    static public void Iniciar(string n, int e, bool v){
        
        nome = n;
        energia = e;
        vivo = v;
    }

    static public void info(){
        Console.WriteLine("Nome jogador.......{0}", nome);
        Console.WriteLine("Energia jogador....{0}", energia);
        Console.WriteLine("Estado jogador.....{0}\n", vivo?"Vivo":"Morto");
    }

    //~Jogador(){
    //    Console.WriteLine("Jogador {0} Destruido!", nome);
    //}
}
class Aula31{
    static void Main(){
        Jogador.Iniciar();
        Jogador.info();

        Jogador.Iniciar("Bruno");
        Jogador.info();

        Jogador.Iniciar("Théo", 50, true);
        Jogador.info();

        Jogador.Iniciar("Benegundesfirno", 0, false);
        Jogador.info();    

        Jogador.Iniciar();
        Jogador.info(); 
    }
}