using System;
namespace Basics{
    class DivisibleBy2{
        static void Main(){
            Console.WriteLine("enter a divident:");
        int x=int.Parse(Console.ReadLine());
    
        if(x%2==0){
            Console.WriteLine("yes");
        }
        else
        Console.WriteLine("no");
        }
    }
}