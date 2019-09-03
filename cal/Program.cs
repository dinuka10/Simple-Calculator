using System;


namespace cal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1 : ");
            
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter one of these operations ::  "+ " (+)"+" (-)"+" (x) "+"(/)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1+num2);
            }
            if (op == "-")
            {
                Console.WriteLine(num1-num2);
            }
            if (op == "x")
            {
                Console.WriteLine(num1*num2);
            }
            if (op == "/")
            {
                Console.WriteLine(num1/num2);

            }
                Console.ReadLine();
        }
    }
}
