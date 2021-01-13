using System;
class Aula23{
    static void Main()
    {
        int[] vetor1= new int[5];
        int[] vetor2= new int[5];
        int[] vetor3= new int[5];
        int[,] matriz = new int[2,5]{{11, 22, 5, 44, 55}, {66, 77, 88, 99, 00}};

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

        //public static void CopyTo(Ar_destino,a_partir_desta_posicao)
        Console.WriteLine("\n---------------------------------------");
        vetor1.CopyTo(vetor3, 0);
        foreach (int v in vetor3){
            Console.Write("{0} ", v);
        }

        //public long GetLongLength(dimensão)
        Console.WriteLine("\n---------------------------------------\nGetLongLength");
        long qtdEmentosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("{0} ", qtdEmentosVetor);

        //public int GetLowerBound(dimensão)
        Console.WriteLine("\n---------------------------------------\nGetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(0);
        int MenorIndiceMatriz_D2 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do Vetor é {0} ", MenorIndiceVetor);
        Console.WriteLine("Menor indice da MAtriz D1 é {0} ", MenorIndiceMatriz_D1);
        Console.WriteLine("Menor indice da MAtriz D2 é {0} ", MenorIndiceMatriz_D2);

        //public int GetUpperBound(dimensão)
        Console.WriteLine("\n---------------------------------------\nGetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(0);
        int MaiorIndiceMatriz_D2 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do Vetor é {0} ", MaiorIndiceVetor);
        Console.WriteLine("Maior indice da MAtriz D1 é {0} ", MaiorIndiceMatriz_D1);
        Console.WriteLine("Maior indice da MAtriz D2 é {0} ", MaiorIndiceMatriz_D2);
        
        //public object GetValue(long índice)
        Console.WriteLine("\n---------------------------------------\nGetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor Vetor[3] {0}", valor0);
        Console.WriteLine("Valor Matriz[1,3] {0} ", valor1);

         //public static int IndexOf(array, valor)
        Console.WriteLine("\n---------------------------------------\nIndexOf");
        int indice = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice Vetor[3] {0}", indice);

        //public static int LastIndexOf(array, valor)
        Console.WriteLine("\n---------------------------------------\nLastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice Vetor[3] {0}", indice2);

        //public static void Reverse(array)
        Console.WriteLine("\n---------------------------------------\nReverse");
        foreach (int v in vetor1)
        {
            Console.Write("{0} ",v);
        }

        Array.Reverse(vetor1);

        Console.WriteLine();
        foreach (int v in vetor1)
        {
            Console.Write("{0} ",v);
        }

        //public void SetValue(object valor, long pos)
        Console.WriteLine("\n---------------------------------------\nSetValue");
        foreach (int v in vetor2)
        {
            Console.Write("{0} ",v);
        }
        
        Console.WriteLine("");

        vetor2.SetValue(99, 0);
        
        Console.Write("{0} ",vetor2[0]);

        Console.WriteLine("");

        for(int i=0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        foreach (int v in vetor2)
        {
            Console.Write("{0} ",v);
        }

        //public void Sort(array)
        Console.WriteLine("\n---------------------------------------\nSort");
        foreach (int v in vetor1)
        {
            Console.Write("{0} ",v);
        }

        Console.WriteLine("");

        Array.Sort(vetor1);
        
        Console.WriteLine("Ordem Crescente");
        foreach (int v in vetor1)
        {
            Console.Write("{0} ",v);
        }

        Array.Reverse(vetor1);
        
        Console.WriteLine("Ordem Decrescente");
        foreach (int v in vetor1)
        {
            Console.Write("{0} ",v);
        }
    }   
}