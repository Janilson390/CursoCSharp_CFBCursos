using System;

public class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2){
        this.v1 = v1;
        this.v2 = v2;
    }

    public void Soma(){
        Console.WriteLine("Soma é {0}\n", v1+v2);
    }

    public int Soma1(){
        return v1+v2;
    }
}
class Aula32{
    static void Main(){
        Calculos c1 = new Calculos(10, 20);

        c1.Soma();

        int res = c1.Soma1();
        
        Console.WriteLine("Soma1 é {0}\n", res);
    }
}