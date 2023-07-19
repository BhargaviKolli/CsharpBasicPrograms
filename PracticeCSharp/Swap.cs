using System;
namespace Basics{
    class Swap{
        public static void Main(){
            int a=20,b=30,temp=0;

            Console.WriteLine("before swaping: {0},{1}",a,b);
        //  temp=a;
        //  a=b;
        //  b=temp;

         //without temp

         a=a+b;
         b=a-b;
         a=a-b;

            Console.WriteLine("after swaping: {0},{1}",a,b);
        }
    }
}