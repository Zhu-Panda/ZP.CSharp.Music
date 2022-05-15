using System;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class LaMarseillaise : IScoreProvider
    {
        public Score GetScore()
        {
            return new Score(
                new Voice(
                    new BPM(120),
                    new Note(Pitch.G4, Duration.SemiQuaver),
                    new Note(Pitch.G4, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.G4, Duration.SemiQuaver),
                    new Note(Pitch.C5),
                    new Note(Pitch.C5),
                    new Note(Pitch.D5),
                    new Note(Pitch.D5),
                    new Note(Pitch.G5, Duration.Crotchet | Duration.Quaver),
                    new Note(Pitch.E5, Duration.Quaver),
                    new Note(Pitch.C5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.E5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.A4),
                    new Note(Pitch.F5),
                    new Note(Pitch.Rest),
                    new Note(Pitch.D5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.B4, Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.C5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.SemiQuaver),
                    new Note(Pitch.E5),
                    new Note(Pitch.E5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.E5, Duration.SemiQuaver),
                    new Note(Pitch.E5),
                    new Note(Pitch.F5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.E5, Duration.SemiQuaver),
                    new Note(Pitch.E5),
                    new Note(Pitch.D5),
                    new Note(Pitch.Rest),
                    new Note(Pitch.D5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.E5, Duration.SemiQuaver),
                    new Note(Pitch.F5),
                    new Note(Pitch.F5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.F5, Duration.SemiQuaver),
                    new Note(Pitch.F5),
                    new Note(Pitch.G5, Duration.SemiQuaver | Duration.Quaver),
                    new Note(Pitch.F5, Duration.SemiQuaver),
                    new Note(Pitch.E5, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.G5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.G5, Duration.SemiQuaver),
                    new Note(Pitch.G5),
                    new Note(Pitch.E5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.G5),
                    new Note(Pitch.E5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.G4, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.G4, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.B4, Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.Minim),
                    new Note(Pitch.F5),
                    new Note(Pitch.D5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.B4, Duration.SemiQuaver),
                    new Note(Pitch.C5),
                    new Note(Pitch.C5),
                    new Note(Pitch.ASharp4),
                    new Note(Pitch.Rest),
                    new Note(Pitch.A4),
                    new Note(Pitch.C5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.C5),
                    new Note(Pitch.B4, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.Minim),
                    new Note(Pitch.Rest, Duration.Crotchet | Duration.Quaver),
                    new Note(Pitch.D5, Duration.Quaver),
                    new Note(Pitch.DSharp5, Duration.Crotchet | Duration.Quaver),
                    new Note(Pitch.DSharp5, Duration.Quaver),
                    new Note(Pitch.DSharp5, Duration.Quaver),
                    new Note(Pitch.DSharp5, Duration.Quaver),
                    new Note(Pitch.F5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.G5, Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.DSharp5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.SemiQuaver),
                    new Note(Pitch.C5),
                    new Note(Pitch.C5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.DSharp5),
                    new Note(Pitch.D5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.C5),
                    new Note(Pitch.B4),
                    new Note(Pitch.Rest, Duration.Crotchet | Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.G5, Duration.SemiQuaver),
                    new Note(Pitch.G5, Duration.Minim | Duration.Quaver),
                    new Note(Pitch.G5, Duration.Quaver),
                    new Note(Pitch.E5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.Minim),
                    new Note(Pitch.Rest, Duration.Crotchet | Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.G5, Duration.SemiQuaver),
                    new Note(Pitch.G5, Duration.Minim | Duration.Quaver),
                    new Note(Pitch.G5, Duration.Quaver),
                    new Note(Pitch.E5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.G4),
                    new Note(Pitch.C5, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.C5),
                    new Note(Pitch.E5, Duration.Minim),
                    new Note(Pitch.Rest, Duration.Minim),
                    new Note(Pitch.F5, Duration.Minim),
                    new Note(Pitch.G5),
                    new Note(Pitch.A5),
                    new Note(Pitch.D5, Duration.Minim),
                    new Note(Pitch.Rest),
                    new Note(Pitch.A5),
                    new Note(Pitch.G5, Duration.Minim),
                    new Note(Pitch.Rest, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.E5, Duration.SemiQuaver),
                    new Note(Pitch.F5, Duration.Quaver | Duration.SemiQuaver),
                    new Note(Pitch.D5, Duration.SemiQuaver),
                    new Note(Pitch.C5, Duration.Minim)
                )
            );
        }
    }
}