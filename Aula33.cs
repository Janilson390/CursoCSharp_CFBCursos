using System;

class Jogador{
    private int energia;
    private string nome;

    public Jogador(){
    }
    public Jogador(string nome){
        this.nome = nome;
        energia=100;
    }

    public int getEnergia(){
        return energia;
    }

    public void setEnergia(int energia){
        if(energia < 0){
            if(this.energia+energia < 0){
                this.energia = 0;
            }else{
                this.energia += energia;
            }
        }else if(energia > 0){
            if(this.energia+energia > 100){
                this.energia = 100;
            }else{
                this.energia += energia;
            }
        }
    }

    public string getNome(){
        return nome;
    }

    public void setNome(string nome){
        this.nome = nome;
    }
    public void Info(){
        Console.WriteLine("Nome: {0} \nEnergia: {1}\n", nome, energia);
    }
}

class Aula33{
    static void Main(){
        Jogador j1 = new Jogador("Janilson");

        Console.WriteLine("Nome: {0} \nEnergia: {1}\n", j1.getNome(), j1.getEnergia());

        j1.setEnergia(-120);

        j1.Info();

        Jogador j2 = new Jogador();

        j2.setNome("Mayara");
        
        j2.setEnergia(50);

        j2.Info();

        j2.setEnergia(-20);
        
        j2.Info();
        
        j2.setEnergia(-20);
        
        j2.setEnergia(-20);
        
        j2.Info();        
    }
}