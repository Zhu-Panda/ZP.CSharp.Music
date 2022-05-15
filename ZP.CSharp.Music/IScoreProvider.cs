using System;
using System.Collections.Generic;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface IScoreProvider
    {
        public Score GetScore();
    }
}