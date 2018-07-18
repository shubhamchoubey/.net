

    /*
    // Sample code to perform I/O:
     
    name = Console.ReadLine();                  // Reading input from STDIN
    Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT
     
    // Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
    */
     
    // Write your code here
    using System;
    namespace PrimeNumbersApplication
    {
        class PrimeNumbers
    {
        static void Main(String[] args)
        {
            int N;
            N=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2 ");
            if(N>5)
            
            {
                Console.Write("2 ");
                for(int i=3;i<=N;i++)
                {
                    int count=0;
                    for(int j=2;j<=N-1;j++)
                    {
                        if(i>j && i%j==0)
                            count+=1;
                    }
                    if(count==0)
                        Console.Write(i+" ");
                        //Console.Write(count) ;
                }
               
            }
            
            else if(N>2 && N<5)
                {
                    for(int i=3;i<=N;i++)
                    {
                        if(i%2!=0)
                            Console.Write(N+" ");
                    }
                    
                }
        }
        
    }
        
    }


