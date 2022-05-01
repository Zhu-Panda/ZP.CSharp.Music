using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Piece : IPlayable
    {
        public static Piece Empty => new Piece(new Voice(new Note(120, Pitch.Rest)));
        public double BPM {get; set;}
        public List<Voice> Voices;
        public Piece(List<Voice> voices)
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
    }
}