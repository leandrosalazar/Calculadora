using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {

      public int Sumar(int numero1, int numero2)
      {
            var x = 0;


            for (int i = 0; i <= numero2; i++)
            {
                x = numero1++;

            }
            return x;
      }

        public string Restar(int numero1, int numero2)
        {

            var x = 0;




            if (numero1 >=
                numero2)
            {
                for (int i = numero2; i < numero1; i++)
                {
                    x++;
                }
                return x.ToString();
            }
            else
            {
                for (int i = numero1; i < numero2; i++)
                {
                    x++;
                }


                return "-" + x;
            }           


        }

        public int Multiplicar (int numero1, int numero2)
        {
            var resultado = 0;

            for (int i = 0; i < numero2; i++)
            {
                resultado = resultado + numero1;
            }
            return resultado;
        }

        public int Division (int numero1, int numero2)
        {
            var division = 0;

            for (int i = 0; i < numero1; i = i + numero2)
            {
                division++;
            }
            return division;
        }


    }
}
