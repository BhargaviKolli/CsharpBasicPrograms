using System;
namespace Basics{
    class EvenOdd{
        public static void Main(){
            Console.WriteLine("enter a number: ");
            int a =int.Parse(Console.ReadLine());
            if(a%2==0){
                Console.WriteLine("{0} is even number.",a);
            }
            else
            Console.WriteLine("{0} is a odd number",a);
        }
    }
}