using System;
using System.Collections;
using System.Collections.Generic;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Chord : IEnumerable<Note>, INote
    {
        private List<Note> Notes;
        public int Duration {get; set;}
        private Chord(List<Note> notes)
        {
            Notes = notes;
            this.Duration = this.Notes.First().Duration;
        }
        public Chord(params Note[] notes)
            : this(notes.ToList())
        {}
        public IEnumerator<Note> GetEnumerator()
        {
            return new NoteEnumerator(this.Notes);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public ISampleProvider GetWaves()
        {
            var waves = new List<ISampleProvider>();
            foreach (var note in this.Notes)
            {
                waves.Add(note.GetWaves());
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
    public class NoteEnumerator : IEnumerator<Note>
    {
        private int Position = -1;
        private readonly List<Note> Notes;
        public Note Current = null!;
        Note IEnumerator<Note>.Current => this.Current;
        object IEnumerator.Current => this.Current;

        public NoteEnumerator(List<Note> notes)
        {
            this.Notes = notes;
        }
        public bool MoveNext()
        {
            try
            {
                this.Current = this.Notes[++this.Position];
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                this.Current = null!;
                return false;
            }
        }
        public void Reset()
        {
            this.Position = -1;
        }
        public void Dispose()
        {}
    }
}