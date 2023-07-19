using System;
namespace Basics{
    class OddRange{
        public static void Main(){
            int n=50;
            for(int i=1; i<=n; i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}