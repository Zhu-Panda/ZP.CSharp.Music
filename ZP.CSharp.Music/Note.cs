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
        public List<IMusicalEntity> ChildEntities {get; set;}
        public string Lyric {get; set;}

        public Note(Pitch pitch, Duration duration = Duration.Crotchet, string lyric = "")
        {
            this.Pitch = pitch;
            this.Duration = duration;
            this.Lyric = lyric;
        }
        public void SetBPM(double bpm)
        {
            this.BPM = bpm;
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
        public string GetLyrics() => this.Lyric;
    }
}
