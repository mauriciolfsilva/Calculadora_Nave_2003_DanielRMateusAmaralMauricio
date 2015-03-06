using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculator
    {
        public double Soma(double a, double b)
        {
            return (a + b);
        }

        public double Subt(double a, double b)
        {
            return (a - b);
        }

        public double Mult(double a, double b)
        {
            return (a * b);
        }

        public double Div(double a, double b)
        {
            return (a / b);
        }

        public double Pot(double a, int b)
        {

            double c = a;

            if (b == 0)
            {
                a = 1;
                return (a);
            }

            else
            {
                while (b > 1)
                {
                    a *= c;
                    b--;
                }
                return (a);


            }

        }
        

        public double Resto(double a, double b)
        {
            return (a % b);
        }

        public double Porcentagem(double a, double b)
        {
            double c = ((100 * b) / a);

            return (c);
        }

        public double Raiz(double a)
        {
            return (Math.Sqrt(a));
        }

        public double seno(double a)
        {
            return (Math.Sin(Math.PI*a/180));
        }

        public double cos(double a)
        {
            return (Math.Cos(Math.PI*a/180));
        }

        public double tan(double a)
        {
            return (Math.Tan(Math.PI*a/180));
        }
    }
}
