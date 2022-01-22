using System;

namespace UnityLesson_CSharp_If
{
    internal class Program
    {
        static bool condition1=false;     
        static bool condition2=true;
        static bool condition3=false;
        static void Main(string[] args)
        {
            

            if (condition1)
            {
                Console.WriteLine("condition1 true!");
            }
            else if(condition2)
            {
                Console.WriteLine("condition1 false, condition2 true");
            }
            else if (condition3)
            {
                Console.WriteLine("Hello World!3");
            }
            else
            {

            }
        }
        
    }
}
