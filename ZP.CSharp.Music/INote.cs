using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface INote : IPlayable
    {
        public Duration Duration {get; set;}
        public double BPM {get; set;}
        public void SetBPM(double bpm);
    }
}