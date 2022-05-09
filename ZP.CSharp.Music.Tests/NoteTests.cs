using System;
using Xunit;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests.NoteTests;
namespace ZP.CSharp.Music.Tests.NoteTests
{
    public class Assignments
    {
        [Theory]
        [InlineData(123)]
        [InlineData(456)]
        [InlineData(7890)]
        public void BPMCanOnlyBeSetWithSetBPM(double bpm)
        {
            var note = new Note(Pitch.Rest, Duration.Crotchet);
            Assert.NotEqual(bpm, note.BPM);
            note.SetBPM(bpm);
            Assert.Equal(bpm, note.BPM);
        }
        [Theory]
        [InlineData(Pitch.Rest, Duration.Crotchet, "1, 2, 3!")]
        [InlineData(Pitch.C4, Duration.Quaver, "4, 5, 6!")]
        [InlineData(Pitch.G5, Duration.Breve, "7, 8, 9, 0!")]
        public void NormalPropertiesCanBeSet(Pitch pitch, Duration duration, string lyric)
        {
            var note = new Note(pitch, duration, lyric);
            Assert.Equal(pitch, note.Pitch);
            Assert.Equal(duration, note.Duration);
            Assert.Equal(lyric, note.Lyric);
        }
    }
}