using System;
class Aula23{
    static void Main()
    {
        int[] vetor1= new int[5];
        int[] vetor2= new int[5];
        int[] vetor3= new int[5];
        int[,] matriz = new int[2,5]{{11, 22, 00, 44, 55}, {66, 77, 88, 99, 00}};

        Random random = new Random();
        
        for(int i=0; i < vetor1.Length; i++){
            vetor1[i]=random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1 ");
        foreach (int v in vetor1){
            Console.Write("{0} ", v);
        }

        //public static int BinarySearch(array, valor)
        Console.WriteLine("\n---------------------------------------");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        
        if(pos < 0){
            Console.Write("O valor {0} não foi localizado no vetor!", procurado);
        }else{
            Console.Write("O valor {0} está na posição {1}", procurado, pos);
        }

        //public static void Copy(Ar_origem, Ar_destino, qtd_elementos)
        Console.WriteLine("\n---------------------------------------");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int v in vetor2){
            Console.Write("{0} ", v);
        }
    }   
}