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
        C5
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
            return table;
        }
        public static double GetPitch(Pitch pitch)
        {
            return GetTable()[pitch];
        }
    }
}