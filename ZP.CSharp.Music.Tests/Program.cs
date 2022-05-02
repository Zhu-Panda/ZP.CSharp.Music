using System;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests;
namespace ZP.CSharp.Music.Tests
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(
                "Choose song:\n" +
                "1: La Marseillaise"
            );
            var result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Playing...");
            Player.Play(
                result switch
                {
                    1 => new LaMarseillaise().GetPiece(),
                    _ => Piece.Empty
                }
            );
            Console.WriteLine("Done.");
        }
    }
}
