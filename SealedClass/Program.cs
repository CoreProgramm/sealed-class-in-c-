using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public sealed class Calculator {
        public int Add(int x, int y)
        {
            return (x + y);
        }
        public int Sub(int x, int y)
        {
            return (x - y);
        }
        public int Multiply(int x, int y)
        {
            return (x * y);
        }
        public int Division(int x, int y)
        {
            return (x / y);
        }
    }
  public class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            //Add  
            int add = calc.Add(15, 25);
            Console.WriteLine("Your Value is " + add.ToString());
            //Sub  
            int sub = calc.Sub(25, 15);
            Console.WriteLine("Your Value is " + sub.ToString());
            //Multiply  
            int mul = calc.Multiply(15, 5);
            Console.WriteLine("Your Value is " + mul.ToString());
            //Division  
            int div = calc.Division(15, 5);
            Console.WriteLine("Your Value is " + div.ToString());

            Console.ReadLine();
        }
    }
   
}
