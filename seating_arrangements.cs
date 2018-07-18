

    /*
    // Sample code to perform I/O:
     
    name = Console.ReadLine();                  // Reading input from STDIN
    Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT
     
    // Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
    */
     
    // Write your code here
    using System;
    namespace SeatingArrangement
    {
    class SeatArrange
        {
            
            public static string seatingArrangement(int a)
            {
                int rem=a%12,facingseat=0;
                string s=string.Empty;
                
                if(rem==6 || rem==7 || rem==0 || rem==1 )
                    s="WS";
                else if(rem==2 || rem==11 || rem==5 || rem==8)
                    s="MS";
                else if(rem==3 || rem==10 || rem==4 || rem==9)
                    s="AS";
                
                if(s=="WS")
                {
                    if(rem>5)
                    {
                    if(a%2==0)
                        facingseat=a+1;
                    else
                        facingseat=a-1;
                    }
                    else
                    {
                    if(a%2==0)
                        facingseat=a-11;
                    else
                        facingseat=a+11;
                    }
                }    
                else if(s=="MS")
                {
                    if(rem==2 || rem == 11 )
                    {
                        if(a%2==0)
                            facingseat=a+9;
                        else
                            facingseat=a-9;
                    }
                    else
                    {
                        if(a%2==0)
                            facingseat=a-3;
                        else
                            facingseat=a+3;
                    }
                }
                else if(s=="AS")
                {
                    if (rem==3 || rem==10)
                    {
                    if(a%2==0)
                        facingseat=a-7;
                    else
                        facingseat=a+7;
                    }
                    else
                    {
                        if(a%2==0)
                            facingseat=a+5;
                        else
                            facingseat=a-5;
                    }
                    
                }
                    
                return facingseat+" "+s;
            }
            static void Main(string[] args)
            {
                int n=0,inp=0;
                int[] arr=new int[n];
                string x;
                n=Convert.ToInt32(Console.ReadLine());
                
                for(int i=0;i<n;i++)
                   {
                    inp=Convert.ToInt32(Console.ReadLine());
                    x=seatingArrangement(inp);
                    Console.WriteLine(x);
                   }
            }
            
        }
     
    }


