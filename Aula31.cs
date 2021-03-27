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

class Inimigo{
    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta = false;
        nome = n;
    }

    public void info(){
        Console.WriteLine("Nome Inimigo......{0}", nome);
        Console.WriteLine("Status Inimigo....{0}\n", alerta?"Alerta!":"Dormindo!");
    }
}
class Aula31{
    static void Main(){
        Jogador.Iniciar("Bruno");
        Jogador.info();

        Console.WriteLine("--------------------------");

        Inimigo i1 = new Inimigo("Goblin");
        Inimigo i2 = new Inimigo("Gigante");
        Inimigo i3 = new Inimigo("Hárpia");

        i1.info();
        i2.info();
        i3.info();

        Console.WriteLine("--------------------------");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();
    }
}