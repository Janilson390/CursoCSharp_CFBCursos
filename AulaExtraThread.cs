using System;
using System.Threading.Tasks;
using System.Threading;

class Aula23{
    
    static void FazerAlgo(){
        Thread.Sleep(3000); 
        Console.WriteLine("Terminei a tarefa!");
    }
    
    static void Main()
    {
        Thread t = new Thread(new ThreadStart(FazerAlgo));
        
        t.Start();

        Thread.Sleep(4000);
        Console.WriteLine("Thread principal parada por 4 segundos!");

        Console.ReadKey();
    }
}