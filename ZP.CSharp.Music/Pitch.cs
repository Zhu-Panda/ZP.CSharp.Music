using System;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public enum Pitch
    {
        Rest,
        C4,
        CSharp4,
        D4,
        DSharp4,
        E4,
        F4,
        FSharp4,
        G4,
        GSharp4,
        A4,
        ASharp4,
        B4,
        C5,
        CSharp5,
        D5,
        DSharp5,
        E5,
        F5,
        FSharp5,
        G5,
        GSharp5,
        A5,
        ASharp5,
        B5,
        C6
    }
    public static class PitchFinder
    {
        public static SortedList<Pitch, double> GetTable()
        {
            var table = new SortedList<Pitch, double>();
            table.Add(Pitch.Rest, 0);
            table.Add(Pitch.C4, 261.63);
            table.Add(Pitch.CSharp4, 277.18);
            table.Add(Pitch.D4, 293.66);
            table.Add(Pitch.DSharp4, 311.13);
            table.Add(Pitch.E4, 329.63);
            table.Add(Pitch.F4, 349.23);
            table.Add(Pitch.FSharp4, 369.99);
            table.Add(Pitch.G4, 392);
            table.Add(Pitch.GSharp4, 415.3);
            table.Add(Pitch.A4, 440);
            table.Add(Pitch.ASharp4, 466.16);
            table.Add(Pitch.B4, 493.88);
            table.Add(Pitch.C5, 523.25);
            table.Add(Pitch.CSharp5, 554.37);
            table.Add(Pitch.D5, 587.33);
            table.Add(Pitch.DSharp5, 622.25);
            table.Add(Pitch.E5, 659.25);
            table.Add(Pitch.F5, 698.46);
            table.Add(Pitch.FSharp5, 739.99);
            table.Add(Pitch.G5, 783.99);
            table.Add(Pitch.GSharp5, 830.61);
            table.Add(Pitch.A5, 880);
            table.Add(Pitch.ASharp5, 932.33);
            table.Add(Pitch.B5, 987.77);
            table.Add(Pitch.C6, 1046.5);
            return table;
        }
        public static double GetPitch(Pitch pitch)
        {
            return GetTable()[pitch];
        }
    }
}