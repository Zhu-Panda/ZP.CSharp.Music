using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class BPM : IMusicalEntity
    {
        public double Value;
        public BPM(double bpm)
        {
            this.Value = bpm;
        }

        public Duration Duration {get; set;}
        public List<IMusicalEntity> ChildEntities {get; set;}
        public string Lyric {get; set;} = "";
        public ISampleProvider GetWaves()
        {
            return new Empty().GetWaves();
        }
        public string GetLyrics() => this.Lyric;
        public void SetBPM(double bpm)
        {}
    }
}