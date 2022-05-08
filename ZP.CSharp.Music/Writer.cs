using System;
using ZP.CSharp.Music;
namespace ZP.CSharp.Music
{
    public static class Writer
    {
        public static void Write(IPlayable playable, Action<string> action) => action(playable.GetLyrics() + "\n");
        public static async Task WriteAsync(IPlayable playable, Action<string> action) => await Task.Run(() => Write(playable, action));
    }
}