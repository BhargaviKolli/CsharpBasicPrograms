using System;
namespace Basics{
    class Exponential{
        static void Main(){
            int exp1,exp2,pow,num;
            Console.WriteLine("enter power of number :");
            num=int.Parse(Console.ReadLine());
            exp1=int.Parse(Console.ReadLine());
                       
            exp2=int.Parse(Console.ReadLine());

            pow=exp1+exp2;

            Console.WriteLine(Math.Pow(num,pow));


            pow=exp1-exp2;
            Consomole.WriteLine(Math.Pow(num,pow));

        }
    }
}