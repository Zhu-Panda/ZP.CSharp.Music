using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Empty : IMusicalEntity
    {
        public ISampleProvider GetWaves()
        {
            return new SignalGenerator()
            { 
                Gain = 0.2,
                Frequency = PitchFinder.GetPitch(Pitch.Rest),
                Type = SignalGeneratorType.Triangle
            }.Take(TimeSpan.FromMilliseconds(0.05));
        }
    }
}