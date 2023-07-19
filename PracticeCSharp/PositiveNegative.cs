using System;
namespace Basics{
    class PositiveNegativeNumber{
        public static void Main(){
            Console.WriteLine("enter a number:");
            int a=int.Parse(Console.ReadLine());
             if(a<0){
                Console.WriteLine("{0} is negative number.",a);
             }
             else{
                Console.WriteLine("{0} is positive number.",a);
             }
        }
    }
}