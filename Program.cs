namespace Lab02_RecursividadFibonacci;
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
     static int FibonacciRecursivo(int n){
             if(n < 2){
                 return n;
             }
             else
             {
                 return FibonacciRecursivo(n-2) + FibonacciRecursivo(n-1);
             }
         }
         static void FibonacciIterativo(int n){
             int i;
             int ant1=1,ant2=1;
             Stopwatch stopWatch1 = new Stopwatch();
             stopWatch1.Start();
             Console.Write("0 1 1 ");

             for(i = 1;i < (n-2);i++){
                 int a = ant1 + ant2;
                 Console.Write(a + " ");
                 ant2 = ant1;
                 ant1 = a;
             }
             stopWatch1.Stop();
             Console.WriteLine($"Tiempo en Iterativo-> {stopWatch1.Elapsed.TotalMilliseconds} ms");

         }

         static void Main(string[] args)
         {
             Stopwatch stopWatch2 = new Stopwatch();
             string recursivo="";
             int n,j;
             do{
                 Console.WriteLine("Introduzca el número de términos: ");
                 n = int.Parse(Console.ReadLine());

             } while (n<=1);
                 Console.WriteLine("\tSerie numero de fibonacci recursivo ");
                 stopWatch2.Start();

                 for(j = 0 ; j<n ; j++){
                     recursivo += FibonacciRecursivo(j) + " ";
                 }
                 stopWatch2.Stop();

                 Console.WriteLine(recursivo+"\n");
                 Console.WriteLine($"Tiempo en Recursividad -> {stopWatch2.Elapsed.TotalMilliseconds} ms");
                 Console.WriteLine("\tSerie numero de fibonacci iterativo ");

                 FibonacciIterativo(n);
         }
     }