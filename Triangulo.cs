using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area_do_triangulo
{
    public class Triangulo
    {
        private double altura;
        private double bas;

        public double Altura 
        {
            get { return altura; }
            set {
                altura = value; 
                    if (value <= 0) { altura = 0; }
            }
        }

        public double Bas
        {
            get { return bas; }
            set {
                bas = value; 
                if (value <= 0) { bas = 0; }
            }
        }

        public void Mensagem()
        {
            double soma = (altura * bas) / 2;
            Console.WriteLine("A area do triangulo e: "+soma);
        }

    }
}
