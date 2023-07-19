using System;
namespace Basics
{
    class FibonacciSeries{
      public  static void Main(String[] args){

            int i=0, a=0,b=1,c=0;
            Console.WriteLine(a);
            Console.WriteLine(b);

        while(i<=10){
                c=a+b;
                a=b;
                b=c;
                    Console.WriteLine(c);
                 i++;
            }
         
        }


    }
}
