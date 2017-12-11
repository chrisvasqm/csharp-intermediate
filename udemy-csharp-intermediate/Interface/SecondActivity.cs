using System;

namespace udemy_csharp_intermediate.Interface
{
    public class SecondActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing second activity");
        }
    }
}