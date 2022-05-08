using System;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface IMusicalEntity : IPlayable
    {
        public List<IMusicalEntity> ChildEntities {get; set;}
        public string Lyric {get; set;}
    }
}