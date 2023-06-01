
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
                
            } while (!valido || numIngresado < 0);
            
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
  
  
    public class Calculadora
    {    
       public int num1, num2, resultado; 

       public int sumar( int num1, int num2){
        resultado = num1 +num2;
        return resultado;
       }
       public int restar( int num1, int num2){
        resultado = num1 -num2;
        return resultado;
       }
       public int multiplicar( int num1, int num2){
        resultado = num1 *num2;
        return resultado;
       }
       public int dividir( int num1, int num2){
        string entrada;
        bool valido = false;
        if (num2 == 0)
        {  
            do
            {
                Console.WriteLine("el divisor debe ser distinto de cero, ingrese otro divisor");
                entrada = Console.ReadLine();
                valido = int.TryParse(entrada, out num2);
            } while (num2 == 0 || !valido);      
        }
        resultado = num1 / num2;
        return resultado;
       }
       public int valorAbsoluto (int num1){
        int resultado = 0; 
        if(num1 <0){
            num1 = num1 *(-1);
            resultado = num1;
        }
        else
        {
            resultado = num1;
        }
        return resultado;

       }

          public void pedirUnNumero (){
        int numIngresado; 
        bool valido = false;
        string entrada; 
        do
        {
        Console.WriteLine("ingrese un numero ");
        entrada = Console.ReadLine(); 
         valido = int.TryParse(entrada, out num1);
         if (!valido)
         {
            Console.WriteLine(" el numero  ingresado no es valido");         
         }
        } while (!valido);
        }
       public void pedirNumeros (){
        int numIngresado; 
        bool valido = false;
        string entrada; 
        do
        {
        Console.WriteLine("ingrese el primer numero ");
        entrada = Console.ReadLine(); 
         valido = int.TryParse(entrada, out num1);
         if (!valido)
         {
            Console.WriteLine(" el numero  ingresado no es valido");         
         }
        } while (!valido);
       do
        {
        Console.WriteLine("ingrese el segundo numero ");
        entrada = Console.ReadLine(); 
         valido = int.TryParse(entrada, out num2);
         if (!valido)
         {
            Console.WriteLine(" el numero  ingresado no es valido");         
         }
        } while (!valido);
      

       }


        
    }
    
    public class interfasCalculadora
    {
        public int opcion; 
        public Calculadora calc1; 
       public  string entrada; 
        public bool ingreso = false;

        public int ingresarOpcion(){
             do
            { 
                Console.WriteLine("ingrese una opcion para operar: ");
                Console.WriteLine("ingrese 1 para SUMAR ");               
                Console.WriteLine("ingrese 2 para RESTAR ");              
                Console.WriteLine("ingrese 3 para MULTIPLICAR ");
                Console.WriteLine("ingrese 4 para DIVIDIR ");
                 Console.WriteLine("ingrese 5 para VALOR ABSOLUTO ");
                Console.WriteLine("ingrese 0 para SALIR ");
              
                entrada = Console.ReadLine();
                ingreso = int.TryParse(entrada, out opcion);
                if (!ingreso || opcion <0 || opcion > 5)
                {
                    Console.WriteLine("ingreso una opcion no valida ");

                }
            } while (!ingreso|| opcion <0 || opcion > 5 );

            return opcion;
        }
        
        public void calcular(int opcion ){
            calc1 = new Calculadora(); 

            switch (opcion)
            {
                
                case 1:
                        calc1.pedirNumeros();
                        Console.Write(" El resultado de la suma es ");
                        Console.WriteLine(calc1.sumar(calc1.num1, calc1.num2));
                        break;

                    case 2:
                        calc1.pedirNumeros();
                        Console.Write(" El resultado de la resta es ");
                       
                        Console.WriteLine(calc1.restar(calc1.num1, calc1.num2));
                        break;

                    case 3:
                        calc1.pedirNumeros();
                         Console.Write(" El resultado de la multiplicacion es ");
                        Console.WriteLine(calc1.multiplicar(calc1.num1, calc1.num2));
                        break;

                    case 4:
                        calc1.pedirNumeros();
                        Console.Write(" El resultado de la division es ");
                        Console.WriteLine(calc1.dividir(calc1.num1, calc1.num2));
                        break;
                    case 5:
                        calc1.pedirUnNumero();
                        Console.Write(" El resultado del valor absoluto es ");
                        Console.WriteLine(calc1.valorAbsoluto(calc1.num1));
                        break;    

                    default:
                        Console.Write(" La opcion es incorrecta ");
                        break;
            }
           

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
            int opcion;
            a = 10;
            b = a;
            Console.WriteLine("valor de a:" + a);
            Console.WriteLine("valor de b:" + b);
             b = invertirProg.pedir(); 
             Console.WriteLine(" el numero ingresado es " + b);
            Console.Write(" el numero invertido es "); 


             invertirProg.InvertirNum(b);

            do
            { 
                interfasCalculadora interfas1 = new interfasCalculadora(); 
            opcion = interfas1.ingresarOpcion(); 
            if (opcion != 0)
            {
                interfas1.calcular(opcion);
                
            } 
            else
            {
                Console.WriteLine(" gracias x usar nuestro sistema");
            }
            
                
            } while (opcion != 0);
             

            
        }
    }
}