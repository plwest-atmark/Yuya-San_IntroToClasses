using ClassesAndMethods.NonStaticClasses;
using System;

namespace ClassesAndMethods
{
    class Program
    {
        static private Calculator _calculator;


        static void Main(string[] args)
        {
            _calculator = new Calculator();
            Console.WriteLine(_calculator.AddInt(1234, 4321));
            Console.WriteLine(_calculator.AddDouble(1234567890, 9876543211));
            Console.WriteLine(_calculator.AddDecimal(12.34M, 43.21M));
            Console.WriteLine(_calculator.SubInt(323, 321));
            Console.WriteLine(_calculator.SubDouble(987654321,123456789));
            Console.WriteLine(_calculator.SubDecimal(8743.34M, 4567.55M));
            Console.WriteLine(_calculator.MulInt(29, 29));
            Console.WriteLine(_calculator.MulDouble(33435, 8064));
            Console.WriteLine(_calculator.MulDecimal(498.4M,64.5M));
            Console.WriteLine(_calculator.DivInt(81, 9));
            Console.WriteLine(_calculator.DivDouble(40000000000000, 8));
            Console.WriteLine(_calculator.DivDecimal(149.5M, 11.5M));
            Console.WriteLine(_calculator.RemInt(16, 3));
            Console.WriteLine(_calculator.RemDouble(12345666556, 51));
            Console.WriteLine(_calculator.RemDecimal(99.8M, 4));
            Console.WriteLine(_calculator.PowInt(2, 3));

            double radiusv1 = 5;
            double radiusv2 = 5;
            Console.WriteLine(_calculator.MulDouble(radiusv1,radiusv2, Math.PI));

            double diameter = 10;
            Console.WriteLine(_calculator.MulDouble(diameter, Math.PI));

            decimal tax = 1.08M;
            Console.WriteLine(_calculator.MulDecimal(1550, tax));

            decimal antitax = 1.08M;
            Console.WriteLine(_calculator.DivDecimal(1550, antitax));

            double a = 13;
            Console.WriteLine(_calculator.MulDouble(a, Math.Sqrt(2)));

            double b = 1;
            Console.WriteLine(_calculator.MulDouble(b, b, Math.Sqrt(2)));

            Console.WriteLine(_calculator.MulInt(3, 4, 5));

            Console.WriteLine(_calculator.MulDouble(Math.Sqrt(3), Math.Sqrt(8)));

            Console.WriteLine(_calculator.MulDouble(2, 2, 2, 2));

            //Console.WriteLine(_calculator.MulInt(Math.Pow(2, 3)));

            Console.WriteLine(_calculator.DivDouble(5 * 3, 3));




            



            

            




        }
    }
}
