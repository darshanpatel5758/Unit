using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fizz = new FizzBuzzBaz();
            Fizz.FizzBuzzBaz1();

        }

        

        
    }

    public class TempCon
    {
        public double TempConvert(double number, char system)
        {
            if (system.Equals('f'))
            {
                var result = (number - 32) * 5 / 9;
                return result;
            }
            else
            {
                var result = (number * 9 / 5) + 32;
                return result;
            }
        }
       

    }

    public class FizzBuzzBaz
    {
        
       
        public string Fizz(int num)
        {
            if (num%3==0 || num.ToString().Contains("3"))
            {
                return "Fizz";
            }
            return "";
            
        }

        public string Buzz(int num)
        {
            if (num%5==0 || num.ToString().Contains("5"))
            {
                return "Buzz";
            }
            return "";

        }

        public string Baz(int num)
        {

            if (num%7==0 || num.ToString().Contains("7"))
            {
                return "Baz";

            }
            return "";
            
        }

        public void FizzBuzzBaz1()
        {
            string thingy;

            for (int i = 1; i <= 100; i++)
            {                
                Console.Write($"{i} ");
                thingy = Fizz(i);
                Console.Write(thingy);
                thingy = Buzz(i);
                Console.Write(thingy);
                thingy = Baz(i);
                Console.WriteLine(thingy);
            }

        }

    }



}
