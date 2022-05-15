using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Voice : IMusicalEntity
    {
        public List<IMusicalEntity> ChildEntities {get; set;} = new List<IMusicalEntity>();
        public double BPM;
        public Voice(List<IMusicalEntity> entities)
        {
            this.AddNotes(entities);
        }
        public Voice(params IMusicalEntity[] entities)
            : this(entities.ToList())
        {}
        public void AddNote(IMusicalEntity entity)
        {
            this.AddNotes(entity);
        }
        public void AddNotes(List<IMusicalEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.ChildEntities.Add(entity);
            }
        }
        public void AddNotes(params IMusicalEntity[] notes)
        {
            this.AddNotes(notes.ToList());
        }
        public string Lyric {get; set;} = "";
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
            var notes = new List<IMusicalEntity>(this.ChildEntities);
            var waves = new Empty().GetWaves();
            foreach (var note in notes)
            {
                if (note is BPM bpm)
                {
                    this.BPM = bpm.Value;
                }
                else if (note is INote iNote)
                {
                    iNote.SetBPM(this.BPM);
                }
                waves = waves.FollowedBy(note.GetWaves());
            }
            return waves;
        }
    }
}