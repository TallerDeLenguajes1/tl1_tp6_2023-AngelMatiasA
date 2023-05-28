
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
   public class Invetir{
        int numIngresado = 0; 
        string Ingresado ; 
        bool valido; 
        
        public int pedir(){
            valido = false;
            do
            {
                Console.WriteLine("ingrese un numero positivo "); 
            valido = false; 
            Ingresado = Console.ReadLine();
            valido = int.TryParse(Ingresado, out numIngresado); 
            if (!valido || numIngresado < 0)
            {
                Console.WriteLine("el numero ingresado no es valido");
            }
                
            } while (!valido);
            
            return numIngresado;
        }  

        public void InvertirNum(int numAInvertir){ 
            int aux, resto;

            while( numAInvertir>= 10){ 
                resto = numAInvertir % 10; 
                numAInvertir = numAInvertir/10; 
                Console.Write(resto);
            }
            Console.Write(numAInvertir);

        }

    }
    internal class Program
    { 
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Invetir invertirProg = new Invetir();
            int a;
            int b;
            a = 10;
            b = a;
            Console.WriteLine("valor de a:" + a);
            Console.WriteLine("valor de b:" + b);
             b = invertirProg.pedir(); 
             Console.WriteLine(" el numero ingresado es " + b);
            Console.Write(" el numero invertido es ");


             invertirProg.InvertirNum(b);
            
        }
    }
}