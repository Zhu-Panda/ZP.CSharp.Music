using System;
using System.Collections.Generic;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public interface IPieceProvider
    {
        public static IPlayable GetPiece() => throw new NotImplementedException();
    }
}