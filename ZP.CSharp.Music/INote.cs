using System;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface INote : IMusicalEntity
    {
        public Duration Duration {get; set;}
        public double BPM {get; set;}
        public void SetBPM(double bpm);
    }
}