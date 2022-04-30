using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface IPlayable
    {
        public void Play();
        public ISampleProvider GetWaves();
    }
}