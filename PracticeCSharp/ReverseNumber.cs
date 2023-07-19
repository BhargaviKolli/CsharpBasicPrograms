using System;
namespace Basics{
    class ReverseNumber{
        public static void Main(){
            int n=987654,sum=0,rem=0;
            while(n>0){
                rem=n%10;
                sum=sum*10+rem;
              n=n/10;
            }
              
            Console.WriteLine(sum);
        }
    }
}