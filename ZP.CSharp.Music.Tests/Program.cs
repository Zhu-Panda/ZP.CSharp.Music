using System;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests;
namespace ZP.CSharp.Music.Tests
{
    public class Program
    {
        public static async Task Main()
        {
            Console.WriteLine(
                "Choose song:\n" +
                "1: La Marseillaise\n" + 
                "2: Preußens Gloria"
            );
            var result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Playing...");
            var score = result switch
            {
                1 => new LaMarseillaise().GetScore(),
                2 => new PreußensGloria().GetScore(),
                _ => Score.Empty
            };
            var play = Player.PlayAsync(score);
            var write = Writer.WriteAsync(score, (str) => {Console.WriteLine(str);});
            await Task.WhenAll(play, write);
            Console.WriteLine("Done.");
        }
    }
}
