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
        public Duration Duration {get; set;}
        public double BPM {get; set;}
        public Note(double bpm, Pitch pitch, Duration duration = Duration.Crotchet)
        {
            this.BPM = bpm;
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
            }.Take(
                TimeSpan.FromMilliseconds(
                    DurationFinder.GetDuration(this.BPM, this.Duration) * 0.95
                )
            ).FollowedBy(
                new SignalGenerator()
                { 
                    Gain = 0.2,
                    Frequency = PitchFinder.GetPitch(Pitch.Rest),
                    Type = SignalGeneratorType.Triangle
                }.Take(
                    TimeSpan.FromMilliseconds(
                        DurationFinder.GetDuration(this.BPM, this.Duration) * 0.05
                    )
                )
            );
        }
    }
}
