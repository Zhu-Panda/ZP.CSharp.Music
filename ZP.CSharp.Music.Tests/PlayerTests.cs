using System;
using Xunit;
using NAudio.Wave;
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
        public static TheoryData<IPlayable> CMajorChord
        {
            get
            {
                return new TheoryData<IPlayable>()
                {
                    new Voice(
                        new BPM(120, Duration.Minim),
                        new Chord(new Note(Pitch.C4), new Note(Pitch.E4), new Note(Pitch.G4)),
                        new Chord(new Note(Pitch.E4), new Note(Pitch.G4), new Note(Pitch.C5)),
                        new Chord(new Note(Pitch.G4), new Note(Pitch.C5), new Note(Pitch.E5))
                    )
                };
            }
        }
        [Theory]
        [MemberData(nameof(CMajorScale))]
        [MemberData(nameof(CMajorScaleBlindOctave))]
        [MemberData(nameof(CMajorChord))]
        [Trait("PlaysSound", "true")]
        public void PlayerOutputsSoundFromIPlayable(IPlayable seq)
        {
            Player.Play(seq);
        }
        [Theory]
        [InlineData("C Major Scale.wav")]
        [InlineData("C Major Scale Blind Octave.wav")]
        [Trait("PlaysSound", "true")]
        public void PlayerOutputsSoundFromFile(string file)
        {
            var sounds = new WaveFileReader(file).ToSampleProvider();
            Player.PlayRaw(sounds);
        }
    }
}