using System;
using System.Collections;
using System.Collections.Generic;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Chord : INote
    {
        public Duration Duration {get; set;}
        public double BPM {get; set;}
        public List<IMusicalEntity> ChildEntities {get; set;}
        public string Lyric {get; set;}
        public Chord(List<Note> notes)
        {
            this.ChildEntities = notes.Cast<IMusicalEntity>().ToList();
            this.Duration = this.ChildEntities.Cast<Note>().First().Duration;
            this.Lyric = this.ChildEntities.Cast<Note>().First().Lyric;
        }
        public Chord(params Note[] notes)
            : this(notes.ToList())
        {}
        public void SetBPM(double bpm)
        {
            this.BPM = bpm;
            foreach (var note in this.ChildEntities.Cast<Note>())
            {
                note.SetBPM(this.BPM);
            }
        }
        public ISampleProvider GetWaves()
        {
            var waves = new List<ISampleProvider>();
            foreach (var note in this.ChildEntities)
            {
                waves.Add(note.GetWaves());
            }
            return new MixingSampleProvider(waves);
        }

        public string GetLyrics() => this.Lyric;
    }
}