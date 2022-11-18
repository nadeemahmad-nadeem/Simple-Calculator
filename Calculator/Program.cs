using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Select the operation from below");
            Console.WriteLine("1:Add");
            Console.WriteLine("2:Subtract");
            Console.WriteLine("3:Multiplication");
            Console.WriteLine("4:Division");
            Console.WriteLine("5:Modulus");
            Console.WriteLine("6:Square");
            Console.WriteLine("7:Square Root");
            Console.WriteLine("8:Power Root");

            Console.Write("Enter the operation number : ");

            double opr = Convert.ToDouble(Console.ReadLine());

            double num1;
            double num2;
            double Answer;

            if (opr == 1)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Answer = num1 + num2;
                Console.WriteLine("The Answer is : " + Answer);
            }

            else if (opr == 2)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Answer = num1 - num2;
                Console.WriteLine("The Answer is : " + Answer);
            }
            else if (opr == 3)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Answer = num1 * num2;
                Console.WriteLine("The Answer is : " + Answer);
            }
            else if (opr == 4)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Answer = num1 / num2;
                Console.WriteLine("The Answer is : " + Answer);
            }
            else if (opr == 5)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Answer = num1 % num2;
                Console.WriteLine("The Answer is : " + Answer);
            }
            else if (opr == 6)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Answer = num1 * num1;
                Console.WriteLine("The Answer is : " + Answer);
            }
            else if (opr == 7)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Answer = Math.Sqrt(num1);
                Console.WriteLine("The Answer is : " + Answer);
            }
            else if (opr == 8)
            {
                Console.Write("Enter num1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Answer = Math.Pow(num1, num2);
                Console.WriteLine("The Answer is : " + Answer);
            }
            else
            {
                Console.WriteLine("Operation is invalid");
            }

        }
    }
}
