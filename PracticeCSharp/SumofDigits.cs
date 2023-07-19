using System;
namespace Basics{
    class SumofDigits{
        static void Main(){
            int n=12344,i=0;
            while(n>0){
                int a=n%10;
            i=i+a;
            n=n/10;
              }
              Console.WriteLine(i);
        }
    }
}