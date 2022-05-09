using System;
using Xunit;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests.NoteTests;
namespace ZP.CSharp.Music.Tests.NoteTests
{
    public class Assignments
    {
        [Fact]
        public void BPMCanOnlyBeSetWithSetBPM()
        {
            const int bpm = 120;
            var note = new Note(Pitch.Rest, Duration.Crotchet);
            Assert.NotEqual(bpm, note.BPM);
            note.SetBPM(bpm);
            Assert.Equal(bpm, note.BPM);
        }
        [Fact]
        public void NormalPropertiesCanBeSet()
        {
            const Pitch pitch = Pitch.Rest;
            const Duration duration = Duration.Crotchet;
            const string lyric = "Panda!";
            var note = new Note(pitch, duration, lyric);
            Assert.Equal(pitch, note.Pitch);
            Assert.Equal(duration, note.Duration);
            Assert.Equal(lyric, note.Lyric);
        }
    }
}