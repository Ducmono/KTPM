using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class Result
    {
        private double a, b, c;
        public Result (double a, double b, double c)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
        }
        public Result (double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Execute (string Calaculate)
        {
            double result = 0;
            switch (Calaculate)
            {
                case "b1":
                    if (this.a != 0)
                    {
                        result = -this.b / this.a;
                        result = Math.Round(result, 2);
                        Console.WriteLine("pt có nghiệm: " + result);
                    }
                        
                    else if (this.b != 0)
                    {
                        Console.WriteLine("ptvn");  
                    }
                    else Console.WriteLine("ptsvn");
                    break;
                case "b2":
                    result = this.b * this.b - (4 * this.a * this.c);
                    if (result == 0)
                    {
                        double x= -this.b / (2 * this.a);
                        x = Math.Round(x, 2);
                        Console.WriteLine ("pt nghiệm kép: "+ x);
                    
                    }
                    else if (result < 0)
                    {
                        Console.WriteLine("ptvn");
                    }
                    else
                    {
                        double x1 = (-this.b + Math.Sqrt(result)) / 2 * this.a;
                        double x2 = (-this.b - Math.Sqrt(result)) / 2 * this.a;
                        x1 = Math.Round(x1, 2);
                        x2 = Math.Round(x2, 2);
                        Console.WriteLine("pt có 2 nghiệm pb: "+ x1 + " " + x2);
                    }
                    break;
            }
            return result;
        }
    }
}
