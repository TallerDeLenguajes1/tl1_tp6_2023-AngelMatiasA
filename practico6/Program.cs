
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Invetir
    {
        int numIngresado = 0;
        string Ingresado;
        bool valido;

        public int pedir()
        {
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

        public void InvertirNum(int numAInvertir)
        {
            int aux, resto;

            while (numAInvertir >= 10)
            {
                resto = numAInvertir % 10;
                numAInvertir = numAInvertir / 10;
                Console.Write(resto);
            }
            Console.Write(numAInvertir);

        }

    }


    public class Calculadora
    {
        public int num1, num2, resultado;

        public int sumar(int num1, int num2)
        {
            resultado = num1 + num2;
            return resultado;
        }
        public int restar(int num1, int num2)
        {
            resultado = num1 - num2;
            return resultado;
        }
        public int multiplicar(int num1, int num2)
        {
            resultado = num1 * num2;
            return resultado;
        }
        public int dividir(int num1, int num2)
        {
            string entrada;
            bool valido = false;
            if (num2 == 0)
            {
                do
                {
                    Console.WriteLine("nulo, el divisor debe ser distinto de cero, ingrese otro divisor");
                    entrada = Console.ReadLine();
                    valido = int.TryParse(entrada, out num2);
                } while (num2 == 0 || !valido);
                Console.WriteLine($"el resultado de la division entre {num1} y {num2} es : ");


            }
            resultado = num1 / num2;
            return resultado;
        }
        public int valorAbsoluto(int num1)
        {
            int resultado = 0;
            if (num1 < 0)
            {
                num1 = num1 * (-1);
                resultado = num1;
            }
            else
            {
                resultado = num1;
            }
            return resultado;

        }
        /*● El cuadrado*/

        public int cuadrado(int num1)
        {
            return num1 * num1;
        }



        /*
         ● La raíz cuadrada*/
        public double raizCuadrada(int num1)
        {
            double aux;
            string entrada;
            bool valido = false;
            if (num1 < 0)
            {
                do
                {
                    Console.WriteLine("no definido para los Reales, ingrese otro numero. ");
                    entrada = Console.ReadLine();
                    valido = int.TryParse(entrada, out num1);
                } while (num1 < 0 || !valido);
                Console.WriteLine($"el resultado de la Raiz cuadrada del {num1} : ");


            }

            aux = Convert.ToDouble(num1);
            return Math.Sqrt(num1);
        }

        public double seno(int num1)
        {
            double angulo_en_grados, radianes, seno;
            Console.Write("Ingresa el valor de angulo en grados: ");
            angulo_en_grados = Convert.ToDouble(num1);
            radianes = angulo_en_grados * Math.PI / 180;
            seno = Math.Sin(radianes);

            Console.WriteLine("Valor de radianes: " + radianes);
            Console.WriteLine("Valor de seno: " + seno);
            Console.WriteLine();

            return seno;


        }
        public double coseno(int num1)
        {
            double angulo_en_grados, radianes, seno;
            // Console.Write("Ingresa el valor de angulo en grados: ");
            angulo_en_grados = Convert.ToDouble(num1);
            radianes = angulo_en_grados * Math.PI / 180;

            seno = Math.Cos(radianes);
            Console.WriteLine("Valor de radianes: " + radianes);
            Console.WriteLine("Valor de seno: " + seno);
            Console.WriteLine();

            return seno;


        }
        /*
       
        ● La parte entera de un tipo float.
*/
        public int parteEntera(float num)
        {
            int resultado = 0;
            resultado = Convert.ToInt32(num);
            return resultado;
        }

        public void pedirUnNumero()
        {

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
        public void pedirNumeros()
        {
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
        public string entrada;

        public bool ingreso = false;

        public int ingresarOpcion()
        {
            do
            {
                Console.WriteLine("ingrese una opcion para operar: ");
                Console.WriteLine("ingrese 1 para SUMAR ");
                Console.WriteLine("ingrese 2 para RESTAR ");
                Console.WriteLine("ingrese 3 para MULTIPLICAR ");
                Console.WriteLine("ingrese 4 para DIVIDIR ");
                Console.WriteLine("ingrese 5 para obtener el VALOR ABSOLUTO ");
                Console.WriteLine("ingrese 6 para obtener EL CUADRADO");
                Console.WriteLine("ingrese 7 para  obtener LA RAIZ CUADRADA ");
                Console.WriteLine("ingrese 8 para  obtener EL SENO ");
                Console.WriteLine("ingrese 9 para  obtener EL COSENO ");
                Console.WriteLine("ingrese 10 para  obtener La parte entera de un tipo float. ");

                Console.WriteLine("ingrese 0 para SALIR ");

                entrada = Console.ReadLine();
                ingreso = int.TryParse(entrada, out opcion);
                if (!ingreso || opcion < 0 || opcion > 10)
                {
                    Console.WriteLine("ingreso una opcion no valida ");

                }
            } while (!ingreso || opcion < 0 || opcion > 10);

            return opcion;
        }

       
        public int calcularMax(){  
            Calculadora calc2 = new Calculadora(); 
            calc2.pedirNumeros(); 

            
            int mayor= 0; 
            if (calc2.num1< calc2.num2)
            {   
                mayor = calc2.num2;
                
            } else
            {
                mayor = calc2.num1;
            }
              Console.WriteLine($" El mayir numero es : {mayor}");
            return mayor;
        }

        public int calcularMin(){  
            Calculadora calc2 = new Calculadora(); 
            calc2.pedirNumeros(); 

            
            int menor= 0; 
            if (calc2.num1> calc2.num2)
            {   
                menor = calc2.num2;
                
            } else
            {
                menor = calc2.num1;
            }

                Console.WriteLine($" El menor numero es : {menor}");
            return menor;
        }


        /*Pide la opcion por switch*/
        public void calcular(int opcion)
        {

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
                case 6:
                    calc1.pedirUnNumero();
                    Console.Write(" El resultado del cuadrado del numero es ");
                    Console.WriteLine(calc1.cuadrado(calc1.num1));
                    break;

                case 7:
                    calc1.pedirUnNumero();
                    Console.Write(" El resultado de la Raiz cuadrada  del numero es ");
                    Console.WriteLine(calc1.raizCuadrada(calc1.num1));
                    break;
                case 8:
                    Console.Write(" Ingrese el angulo en grados ");
                    calc1.pedirUnNumero();
                    Console.Write(" El Seno del num es ");
                    Console.WriteLine(calc1.seno(calc1.num1));
                    break;

                case 9:
                    Console.Write(" Ingrese el angulo en grados ");
                    calc1.pedirUnNumero();
                    Console.Write(" El coseno del num es ");
                    Console.WriteLine(calc1.coseno(calc1.num1));
                    break;

                case 10:
                    bool valido = false;
                    string entrada;
                    float aux;
                    do
                    {
                        Console.Write(" Ingrese el numero float con coma decimal ");
                        entrada = Console.ReadLine();
                        valido = float.TryParse(entrada, out aux);
                        if (!valido)
                        {
                            Console.WriteLine(" el numero  ingresado no es valido ");
                        }
                    } while (!valido);

                    Console.Write($" la parte entera del {aux} num es:  ");
                    Console.WriteLine(calc1.parteEntera(aux));

                    break;


                default:
                    Console.Write(" La opcion es incorrecta ");
                    break;
            }


        }

        public void usarCalculadora()
        {

            do
            {

                opcion = ingresarOpcion();
                if (opcion != 0)
                {
                    calcular(opcion);

                }
                else
                {
                    Console.WriteLine("gracias x usar nuestro sistema");
                }


            } while (opcion != 0);

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
            interfasCalculadora interfas1 = new interfasCalculadora();
            interfas1.usarCalculadora(); 
            interfas1.calcularMax();
            interfas1.calcularMin();



        }
    }
}