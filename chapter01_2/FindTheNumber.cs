//using System;
//namespace chapter01_2
//{
//    public class test
//    {
//        public static void Main(string[] agrs)
//        {
//            int size;
//            int[] number;
//            int findnumber;
//            bool checkNumber = false;


//            Console.Write("PLease enter size of arry :");
//            size = Convert.ToInt32(Console.ReadLine());


//            number = new int[size];

//            for (int i = 0; i <= size - 1; i++)
//            {
//                Console.Write("please enter number : ");
//                number[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("number form for");
//            for (int j = 0; j <= size - 1; j++)
//            {
//                Console.Write("{0} ", number[j]);
//            }
//            Console.WriteLine("\nnumber form foreach");
//            foreach (int num in number)
//            {
//                Console.Write("{0} ", num);
//            }

//            Console.WriteLine(" ");

//            Console.Write("Please enter number to find ");
//            findnumber = Convert.ToInt32(Console.ReadLine());

//            foreach (int num in number)
//            {
//                if (findnumber == num)
//                {
//                    Console.WriteLine("this number is in array");
//                    checkNumber = true;
//                    break;
//                }

//            }
//            if (!checkNumber)
//            {
//                Console.WriteLine("this number is not in array");
//            }



//        }
//    }
//}

