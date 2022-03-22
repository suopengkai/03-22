using System;

namespace SampleProgram
{
    public static class Program
    {
        public static void Main()
        {
            var game = new Game();
            // var game = new ComplexGame();

            game.Setup();
            game.Play(15);

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}