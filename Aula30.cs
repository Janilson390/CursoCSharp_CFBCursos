using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        energia = 100;
        vivo = true;
    }
    
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v){
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info(){
        Console.WriteLine("Nome jogador.......{0}", nome);
        Console.WriteLine("Energia jogador....{0}", energia);
        Console.WriteLine("Estado jogador.....{0}\n", vivo?"Vivo":"Morto");
    }

    //~Jogador(){
    //    Console.WriteLine("Jogador {0} Destruido!", nome);
    //}
}
class Aula29{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Théo", 50, true);
        Jogador j4 = new Jogador("Benegundesfirno", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();        
    }
}