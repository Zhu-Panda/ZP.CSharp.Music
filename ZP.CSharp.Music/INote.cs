using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface INote : IPlayable
    {
        public int Duration {get; set;}
    }
}