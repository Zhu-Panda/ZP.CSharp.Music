using System;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    [Flags]
    public enum Duration
    {
        DemiSemiHemiDemiSemiQuaver = 1,
        SemiHemiDemiSemiQuaver = 2,
        HemiDemiSemiQuaver = 4,
        DemiSemiQuaver = 8,
        SemiQuaver = 16,
        Quaver = 32,
        Crotchet = 64,
        Minim = 128,
        Semibreve = 256,
        Breve = 512,
        Longa = 1024,
        Maxima = 2048
    }
    public static class DurationFinder
    {
        public static double GetDuration(double bpm, Duration duration)
        {
            var msPerBeat = (60 / bpm) * 1000;
            return ((int) duration) * msPerBeat / 64;
        }
    }
}