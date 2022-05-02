using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public static class Player
    {
        public static void Play (IPlayable playable)
        {
            using (var output = new DirectSoundOut())
            {
                output.Init(playable.GetWaves());
                output.Play();
                while (output.PlaybackState == PlaybackState.Playing) {}
            }
        }
        public static async Task PlayAsync(IPlayable playable)
        {
            await Task.Run(() => Play(playable));
        }
    }
}