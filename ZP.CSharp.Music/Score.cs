using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Score : IPlayable
    {
        public static Score Empty => new Score(new Voice(new Note(Pitch.Rest)));
        public string Lyric {get; set;} = "";
        //public double BPM {get; set;}
        public List<IMusicalEntity> ChildEntities;
        public Score(List<IMusicalEntity> entities)
        {
            this.ChildEntities = entities;
        }
        public Score(params IMusicalEntity[] entities)
            : this(entities.ToList())
        {}
        public string GetLyrics()
        {
            var result = string.Empty;
            foreach (var entity in this.ChildEntities)
            {
                result += entity.GetLyrics();
            }
            return result;
        }
        public ISampleProvider GetWaves()
        {
            var waves = new List<ISampleProvider>();
            foreach (var voice in this.ChildEntities)
            {
                waves.Add(voice.GetWaves());
            }
            return new MixingSampleProvider(waves);
        }
    }
}