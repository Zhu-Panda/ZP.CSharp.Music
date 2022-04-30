using System;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Note : INote
    {
        public Pitch Pitch;
        public int Duration {get; set;}
        public Note(Pitch pitch, int duration = 1000)
        {
            this.Pitch = pitch;
            this.Duration = duration;
        }
        public ISampleProvider GetWaves()
        {
            return new SignalGenerator()
            { 
                Gain = 0.2,
                Frequency = PitchFinder.GetPitch(this.Pitch),
                Type = SignalGeneratorType.Triangle
            }.Take(TimeSpan.FromMilliseconds(this.Duration * 0.999));
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
