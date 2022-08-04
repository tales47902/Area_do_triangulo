using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area_do_triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo obj = new Triangulo();
            Console.WriteLine("Informe a altura do triangulo");
            obj.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a base do triangulo");
            obj.Bas = double.Parse(Console.ReadLine());
            obj.Mensagem();
        }
    }
}
