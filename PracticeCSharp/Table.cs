using System;
namespace Basics{
    class Table{
        static void Main(){
        int x=3,n=0;
        for(int i=1; i<=20;i++){
            n=x*i;
            Console.WriteLine($"{x} X {i} = {n} ");
        }
    }
}
}