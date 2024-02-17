//using System;
//namespace chapter01_2
//{
//	public class calscore
//	{
//        public static void Main(string[] agrs)
//        {
//			int student;
//			int[] coursework;
//			int[] midterm;
//			int[] final;
//			int[] sumtotal;

//			Console.Write("Pleas enter the number of student: = ");
//			student = Convert.ToInt32(Console.ReadLine());

//            coursework = new int[student];
//            midterm = new int[student];
//            final = new int[student];
//            sumtotal = new int[student];

//            for (int i =0; i < student; i++)
//			{
//                Console.Write("Pleas enter coursework of student #{0} : = ",i+1);
//				coursework[i] = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Pleas enter midter, of student #{0} : = ", i + 1);
//				midterm[i] = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Pleas enter final of student #{0} : = ", i + 1);
//				final[i] = Convert.ToInt32(Console.ReadLine());
//				sumtotal[i] = coursework[i] + midterm[i] + final[i];
//				Console.WriteLine("-------------------------------------------");

//            }
//			int j  = 1;
//			foreach (int sumscore in sumtotal)
//			{
//				Console.WriteLine("Total marks of student#{0} = {1}", j, sumscore);
//			}



//		}
//	}
//}

