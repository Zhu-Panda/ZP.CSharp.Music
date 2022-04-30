using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public class Voice : IPlayable
    {
        public List<INote> Notes;
        private Voice(List<INote> notes)
        {
            this.Notes = notes;
        }
        public Voice(params INote[] notes)
            : this(notes.ToList())
        {}
        public ISampleProvider GetWaves()
        {
            var waves = new List<ISampleProvider>();
            foreach (var note in this.Notes)
            {
                waves.Add(note.GetWaves());
            }
            return new ConcatenatingSampleProvider(waves);
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