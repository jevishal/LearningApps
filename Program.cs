using System;
using System.Threading.Tasks;

namespace TestAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Method3();
            Console.ReadLine();
        }

      static  async void Method1()
        {
            await Task.Run(() => {
                Method3();
            }) ;

            
        }

      static  async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 2");
                    //Method3();
                }
            });
           // return 2;
        }

      static  void Method3()
        {
            Console.WriteLine("I am method 3");
            Method1();
        }

    }
}
