using System;
namespace Basics{
    class Recursion{
        static void Main(){

           pro p=new pro();
            int num,result;
            Console.WriteLine("enter a number: ");
            num=int.Parse(Console.ReadLine());
            result=p.Sum(12345);
            Console.WriteLine("sum of {0} are = {1}",num,result);
        }
    }
    class pro{
        public int Sum(int num){
            int sum=0,rem=0;
            while(num!=0){
                rem=num%10;
                sum=sum+rem;
                num=num/10;
            }
             return sum;
        }
    }
}