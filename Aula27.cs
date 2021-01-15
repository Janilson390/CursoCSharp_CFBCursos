using System;
class Aula27{
    static void Main()
    {
        soma();
        soma(10);
        soma(10, 20);
    }

    static void soma(params int[]n){
        int res=0;
        if (n.Length < 1){
            Console.WriteLine("Não existe valores para somar!");
        }else if(n.Length < 2){
            Console.WriteLine("Não haverá soma. O valor informado foi somente {0}!", n[0]);
        }else{
            for(int i=0; i < n.Length; i++){
                res+= n[i];
            }
            Console.WriteLine("A soma dos valores é {0}!", res);
        }
    }
}