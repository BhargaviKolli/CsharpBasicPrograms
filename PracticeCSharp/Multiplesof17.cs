using System;
namespace Basics{
    class Multiplesof17{
        static void Main(){
            for(int i=1; i<=100; i++){
                if(i%17==0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}