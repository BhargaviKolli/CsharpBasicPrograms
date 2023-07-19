using System;
namespace Basics{
    class SumofMultiple3and5{
        static void Main(){
            int a=0,b=0,sum=0;
            for(int i=1; i<=100;i++){
                a=i%3;
                b=i%5;
                if(a==0||b==0){
                    Console.WriteLine(i);
                      sum=sum+i;
                }

            }
            Console.WriteLine("sum={0}",sum);
        }
    }
}