using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public static class Player
    {
        public static void Play(IPlayable playable)
        {
            new Thread(new ThreadStart(() => {
                using (var output = new DirectSoundOut())
                {
                    output.Init(playable.GetWaves());
                    output.Play();
                    while (output.PlaybackState == PlaybackState.Playing) {}
                }
            })).Start();
        }
    }
}