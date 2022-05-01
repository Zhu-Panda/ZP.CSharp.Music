using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Voice : IPlayable
    {
        public List<INote> Notes;
        public Voice(List<INote> notes)
        {
            this.Notes = notes;
        }
        public Voice(params INote[] notes)
            : this(notes.ToList())
        {}
        public void AddNote(INote note)
        {
            this.AddNotes(note);
        }
        public void AddNotes(List<INote> notes)
        {
            foreach (var note in notes)
            {
                this.Notes.Add(note);
            }
        }
        public void AddNotes(params INote[] notes)
        {
            this.AddNotes(notes.ToList());
        }
        public ISampleProvider GetWaves()
        {
            var notes = new List<INote>(this.Notes);
            var waves = notes.First().GetWaves();
            notes.RemoveAt(0);
            foreach (var note in notes)
            {
                waves = waves.FollowedBy(note.GetWaves());
            }
            return waves;
        }
    }
}