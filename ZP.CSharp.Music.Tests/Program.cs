using System;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests;
namespace ZP.CSharp.Music.Tests
{
    public class Program
    {
        public static void Main()
        {
            new Piece(
                new Voice(
                    new Note(Pitch.Rest),
                    new Note(Pitch.E4)
                ),
                new Voice(
                    new Note(Pitch.C4, 3000)
                )
            ).Play();
        }
    }
}
