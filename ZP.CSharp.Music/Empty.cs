using System;
using System.Collections.Generic;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Empty : IMusicalEntity
    {
        public List<IMusicalEntity> ChildEntities {get; set;} = new List<IMusicalEntity>();
        public double BPM {get; set;}
        public string Lyric {get; set;} = "";
        public ISampleProvider GetWaves()
        {
            return new SignalGenerator()
            { 
                Gain = 0.2,
                Frequency = PitchFinder.GetPitch(Pitch.Rest),
                Type = SignalGeneratorType.Triangle
            }.Take(TimeSpan.FromMilliseconds(0.05));
        }
        public string GetLyrics() => this.Lyric;
        public void SetBPM(double bpm)
        {}
    }
}