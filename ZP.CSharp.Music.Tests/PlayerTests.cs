using System;
using Xunit;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests.PlayerTests;
namespace ZP.CSharp.Music.Tests.PlayerTests
{
    public class SoundOutput
    {
        public static TheoryData<IPlayable> CMajorScale
        {
            get
            {
                return new TheoryData<IPlayable>()
                {
                    new Voice(
                        new BPM(120, Duration.Minim),
                        new Note(Pitch.C4),
                        new Note(Pitch.D4),
                        new Note(Pitch.E4),
                        new Note(Pitch.F4),
                        new Note(Pitch.G4),
                        new Note(Pitch.A4),
                        new Note(Pitch.B4),
                        new Note(Pitch.C5),
                        new Note(Pitch.C5),
                        new Note(Pitch.B4),
                        new Note(Pitch.A4),
                        new Note(Pitch.G4),
                        new Note(Pitch.F4),
                        new Note(Pitch.E4),
                        new Note(Pitch.D4),
                        new Note(Pitch.C4)
                    )
                };
            }
        }
        public static TheoryData<IPlayable> CMajorScaleBlindOctave
        {
            get
            {
                return new TheoryData<IPlayable>()
                {
                    new Voice(
                        new BPM(120, Duration.Minim),
                        new Note(Pitch.C4),
                        new Note(Pitch.D5),
                        new Note(Pitch.E4),
                        new Note(Pitch.F5),
                        new Note(Pitch.G4),
                        new Note(Pitch.A5),
                        new Note(Pitch.B4),
                        new Note(Pitch.C6),
                        new Note(Pitch.C5),
                        new Note(Pitch.B5),
                        new Note(Pitch.A4),
                        new Note(Pitch.G5),
                        new Note(Pitch.F4),
                        new Note(Pitch.E5),
                        new Note(Pitch.D4),
                        new Note(Pitch.C5)
                    )
                };
            }
        }
        [Theory]
        [MemberData(nameof(CMajorScale))]
        [MemberData(nameof(CMajorScaleBlindOctave))]
        public void PlayerOutputsNoteSound(IPlayable seq)
        {
            Player.Play(seq);
        }
    }
}