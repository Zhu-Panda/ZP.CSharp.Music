using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class BPM : INote
    {
        public double Value;
        public BPM(double bpm)
        {
            this.Value = bpm;
        }

        public Duration Duration {get; set;}
        double INote.BPM {get; set;}
        public ISampleProvider GetWaves()
        {
            return new SignalGenerator()
            { 
                Gain = 0.2,
                Frequency = PitchFinder.GetPitch(Pitch.Rest),
                Type = SignalGeneratorType.Triangle
            }.Take(TimeSpan.FromMilliseconds(0.05));
        }
        public void SetBPM(double bpm)
        {}
    }
}