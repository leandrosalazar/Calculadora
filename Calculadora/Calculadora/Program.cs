using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUMA
            //Console.WriteLine("Vamos a sumar");
            //Console.WriteLine("ingrese un numero");
            //var numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese el segundo numero");
            //var numero2 = Convert.ToInt32(Console.ReadLine());

            //var calculadora = new Calculadora();

            //Console.WriteLine("Resultado: " + calculadora.Sumar(numero1, numero2));
            //Console.ReadKey();


            ////RESTA
            //Console.WriteLine("Vamos a sumar");
            //Console.WriteLine("ingrese un numero");
            //var numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese el segundo numero");
            //var numero2 = Convert.ToInt32(Console.ReadLine());






            ////Console.WriteLine("Vamos a restar");
            ////Console.WriteLine("ingrese un numero");
            ////var numero1 = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("ingrese el segundo numero");
            ////var numero2 = Convert.ToInt32(Console.ReadLine());




            ////Console.WriteLine("Resultado: " + resultado);
            ////Console.ReadKey();
            //Console.WriteLine("Resultado: " + calculadora.Restar(numero1, numero2));
            //Console.ReadKey();




            ////Console.WriteLine("Vamos a multiplicar");
            ////Console.WriteLine("ingrese un numero");
            ////var numero1 = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("ingrese el segundo numero");
            ////var numero2 = Convert.ToInt32(Console.ReadLine());
            ////var resultado = 0;



            //Console.WriteLine("Resultado: " + calculadora.Multiplicar(numero1, numero2));
            //Console.ReadKey();





            ////Console.WriteLine("Vamos a dividir");
            ////Console.WriteLine("ingrese un numero");
            ////var numero1 = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("ingrese el segundo numero");
            ////var numero2 = Convert.ToInt32(Console.ReadLine());


            Calculadora calculadora = new Calculadora();

            //Console.WriteLine("Resultado: " + calculadora.Division(numero1, numero2));
            //Console.ReadKey();

            var numero1 = 0;
            var numero2 = 0;
            Console.WriteLine("Toque 1 para sumar, 2 para restar, 3 para multiplicar y 4 para dividir");
            var opc = Console.ReadLine();
            switch (opc)

            {


                case "1":

                    Console.WriteLine("Ingrese el primer numero: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Resultado: " + calculadora.Sumar(numero1, numero2));
                    Console.ReadKey();
                    break;

                case "2":

                    Console.WriteLine("Ingrese el primer numero: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Resultado: " + calculadora.Restar(numero1, numero2));
                    Console.ReadKey();
                    break;

                case "3":

                    Console.WriteLine("Ingrese el primer numero: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Resultado: " + calculadora.Multiplicar(numero1, numero2));
                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine("Ingrese el primer numero: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Resultado: " + calculadora.Division(numero1, numero2));
                    Console.ReadKey();
                    break;

            }


        }
        
    }
}
