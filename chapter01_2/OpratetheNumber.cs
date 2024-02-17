    using System;
    namespace chapter01_2
    {
	    public class OpratetheNumber
	    {
            public int Pluss(int num1, int num2)
            {
                return num1 + num2;
            }
            public int Minus(int num1, int num2)
            {
                return num1 - num2;
            }
            public int Multi(int num1, int num2)
            {
                return num1 * num2;
            }
            public double Divine(int num1, int num2)
            {
            return (double)num1 / num2;
        }




            public static void Main(string[] agrs)
            {
			    int num1;
			    int num2;
			    string operation;
			    //int result;

			    Console.Write("Please enter frist number : ");
			    num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter frist number : ");
                num2 = Convert.ToInt32(Console.ReadLine());

			    Console.Write("Please enter operation (+ , - ,* ,/ :)");
			    operation = Console.ReadLine();


                OpratetheNumber calculator = new OpratetheNumber();
            if (operation == "+")
            {
                int result = calculator.Pluss(num1, num2);
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
            else if (operation == "-")
            {
                int result = calculator.Minus(num1, num2);
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
            else if (operation == "*")
            {
                int result = calculator.Multi(num1, num2);
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
            else if (operation == "/")
            {
                double result = calculator.Divine(num1, num2);
                Console.WriteLine($"{num1} {operation} {num2} = {result:F2}");
            }
            else Console.WriteLine("Error Please enter just  (+ , - ,* ,/ :)");




            }

       
        }
    }

