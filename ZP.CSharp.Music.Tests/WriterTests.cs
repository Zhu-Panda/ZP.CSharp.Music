using System;
using Xunit;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests.WriterTests;
namespace ZP.CSharp.Music.Tests.WriterTests
{
    public class LyricOutput
    {
        [Theory]
        [InlineData("1, 2, 3!")]
        [InlineData("4, 5, 6!")]
        [InlineData("7, 8, 9, 0!")]
        public void WriterOutputsLyric(string lyric)
        {
            var note = new Note(Pitch.Rest, Duration.Crotchet, lyric);
            var result = string.Empty;
            Writer.Write(note, (str) => result = str);
            Assert.Equal(lyric, result);
        }
    }
}