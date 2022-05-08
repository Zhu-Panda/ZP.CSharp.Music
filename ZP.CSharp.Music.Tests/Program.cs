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
            var piece = result switch
            {
                1 => new LaMarseillaise().GetPiece(),
                2 => new PreußensGloria().GetPiece(),
                _ => Piece.Empty
            };
            var play = Player.PlayAsync(piece);
            var write = Writer.WriteAsync(piece, (str) => {Console.WriteLine(str);});
            await Task.WhenAll(play, write);
            Console.WriteLine("Done.");
        }
    }
}
