using System;
namespace MicroApplication
{
    class Micro
    {
        static void Main(string[] args)
        {
            int testCases;
            testCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string s;
                int N, K;
                s = Console.ReadLine();

                string[] el_k = s.Split(' ');
                N = Convert.ToInt32(el_k[0]);
                K = Convert.ToInt32(el_k[1]);
                string str1;
                str1 = Console.ReadLine();
                int[] usr_arr2 = new int[N];
                string[] usr_arr = str1.Split(' ');
                for (int x = 0; x < N; x++)
                    usr_arr2[x] = Convert.ToInt32(usr_arr[x]);

                int time = 0;
                //Console


                Array.Sort(usr_arr2);
                //Console.WriteLine(K + "      " + usr_arr2);
                time = K - usr_arr2[0];
                if(time<0)
                    Console.WriteLine("0");


                else
                    Console.WriteLine(time);
                //Console.ReadKey();


            }
        }
    }
}


