using System;
using NAudio.Wave;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Repeat : IMusicalEntity
    {
        public List<IMusicalEntity> ChildEntities {get; set;} = new List<IMusicalEntity>();
        public double BPM {get; set;}
        public string Lyric {get; set;} = "";
        public int Times;
        public Repeat(int times, List<IMusicalEntity> entities)
        {
            this.Times = times;
            this.ChildEntities = entities;
        }
        public Repeat(int times, params IMusicalEntity[] entities)
            : this(times, entities.ToList())
        {}
        public string GetLyrics() => this.Lyric;
        public ISampleProvider GetWaves()
        {
            var voice = new Voice(this.ChildEntities);
            var waves = new Empty().GetWaves();
            for (int i = 0; i < this.Times; i++)
            {
                waves = waves.FollowedBy(voice.GetWaves());
            }
            return waves;
            
        }
        public void SetBPM(double bpm)
        {}
    }
}