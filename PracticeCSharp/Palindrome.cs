using System;
namespace Basics{
    class Palindrome{
        static void Main(){
            int n=123,sum=0,rem=0,temp=n;
            while(n>0){

                rem=n%10;
                sum=sum*10+rem;
                n=n/10;
            }
            Console.WriteLine("The reverse of the given n value is {0}",sum);
            if(sum==temp){
                Console.WriteLine("Yes the given number {0} is Palindrome",temp);
            }
            else
            Console.WriteLine("the given number {0} is not a palidrome",temp);
        }
    }
}