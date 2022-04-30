using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Piece : IPlayable
    {
        public List<Voice> Voices;
        private Piece(List<Voice> voices)
        {
            this.Voices = voices;
        }
        public Piece(params Voice[] voices)
            : this(voices.ToList())
        {}
        public ISampleProvider GetWaves()
        {
            var waves = new List<ISampleProvider>();
            foreach (var voice in this.Voices)
            {
                waves.Add(voice.GetWaves());
            }
            return new MixingSampleProvider(waves);
        }
        public void Play()
        {
            new Thread(new ThreadStart(() => {
                using (var output = new DirectSoundOut())
                {
                    output.Init(this.GetWaves());
                    output.Play();
                    while (output.PlaybackState == PlaybackState.Playing) {}
                }
            })).Start();
        }
    }
}