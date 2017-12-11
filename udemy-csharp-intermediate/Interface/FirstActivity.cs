using System;

namespace udemy_csharp_intermediate.Interface
{
    public class FirstActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing first activity");
        }
    }
}