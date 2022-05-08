using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public static class Player
    {
        public static void PlayRaw(ISampleProvider waveProvider)
        {
            using (var output = new DirectSoundOut())
            {
                output.Init(waveProvider);
                output.Play();
                while (output.PlaybackState == PlaybackState.Playing) {}
            }
        }
        public static void Play(IPlayable playable) => PlayRaw(playable.GetWaves());
        public static async Task PlayAsync(IPlayable playable) => await Task.Run(() => Play(playable));
    }
}